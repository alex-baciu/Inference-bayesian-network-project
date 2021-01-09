using System;
using System.Collections.Generic;
using System.Linq;

namespace Generic_Inference_Bayesian_Network
{
    public class InferenceByEnumeration
    {
        public Network Network { get; set; }

        public Node QueriedNode { get; set; }

        private List<Node> SortedNodes { get; set; }

        /// <summary>
        /// Method that sorts nodes ordered by their number of parents
        /// </summary>
        /// <returns></returns>
        public List<Node> TopologicalSort()
        {
            List<Node> networkNodes = new List<Node>();
            networkNodes.AddRange(Network.Nodes.Select(node=>node.DeepCopy()));

            List<Node> sorted = new List<Node>();
            Queue<Node> noParentsNodes = new Queue<Node>();

            networkNodes.ForEach(it =>
            {
                if (it.ParentsIds.Count == 0)
                    noParentsNodes.Enqueue(it);
            });

            networkNodes.ForEach(node =>
            {
                if (noParentsNodes.Count == 0)
                {
                    throw new Exception("Bayesian network's graph has at least one cycle.");
                }
                Node current = noParentsNodes.Dequeue();
                sorted.Add(Network.Nodes.Find(it=>it.Id==current.Id));
                networkNodes.ForEach(it =>
                {
                    if (it.ParentsIds.Contains(current.Id))
                    {
                        it.ParentsIds.Remove(current.Id);
                        if (it.ParentsIds.Count == 0)
                            noParentsNodes.Enqueue(it);
                    }
                });

            });
            return sorted;
        }

        /// <summary>
        /// Recursive function for calculating probability for a node
        /// </summary>
        /// <param name="idx">Nodes's index in SortedNodes list</param>
        /// <returns></returns>
        double CalculateProbability(int idx)
        {
            if (idx >= SortedNodes.Count)
                return 1.0;

            var node = SortedNodes[idx];

            if (node.ObservedValue != "None") //if node was observed
            {
                return CalculateProbForNode(node) * CalculateProbability(idx + 1);
            }
            else
            {
                return CalculateProbForNodeInSum(idx);
            }
            
        }

        /// <summary>
        /// Method that returns probability value from input table of probabilities
        /// </summary>
        /// <param name="node"></param>
        /// <returns>Probability taken from input table of probabilities</returns>
        double CalculateProbForNode(Node node)          //probability is taken from input probabilities' table
        {
            var currentProb = 1.0;
            if (node.ParentsIds.Count == 0)     //if node has no parents
            {
                var value = $" {node.Name}={node.ObservedValue}";
                currentProb = node.Probabilities[value][0];     
            }
            else
            {
                //if node has parents, the probability is a conditioned
                var value = "";
                node.ParentsIds.ForEach(parentId =>
                {
                    var parentFound = Network.Nodes.Find(parent => parent.Id == parentId);
                    value += $" {parentFound.Name}={parentFound.ObservedValue}";
                }
                );
                int idx = node.NodeDomainValues.FindIndex(it => it == node.ObservedValue);
                currentProb = node.Probabilities[value][idx];
            }
            return currentProb;
        }

        /// <summary>
        /// Method for calculating probbaility when a node is not observed
        /// For this node, every possible domain value is taken into consideration
        /// </summary>
        /// <param name="idx">Node's index in sortedNodes list </param>
        /// <returns></returns>
        
        double CalculateProbForNodeInSum(int idx)
        {
            if (idx >= SortedNodes.Count)
                return 1.0;

            Node node = SortedNodes[idx];
            if(node.ObservedValue != "None")
            {
                return CalculateProbForNode(node)*CalculateProbForNodeInSum(idx+1);
            }

            double Sum = 0.0;
          
            node.NodeDomainValues.ForEach(value =>
            {
                node.ObservedValue = value;
                var currentProb = CalculateProbForNode(node);
                Sum += currentProb * CalculateProbForNodeInSum(idx + 1);
            });
            node.ObservedValue = "None";
            return Sum;
        }


        /// <summary>
        /// Method for calculating probabilities for the queried node
        /// </summary>
        /// <returns>List of all calculated probabilities, one for each possible 
        /// value for the queried node</returns>
        public List<double> QueryNode()
        {
            SortedNodes = TopologicalSort(); 
            List<double> probabilities = new List<double>();
            if (QueriedNode.ObservedValue != "None")            // if node was already observed, return observed probabilities
            {
                QueriedNode.NodeDomainValues.ForEach(val =>
                probabilities.Add(val != QueriedNode.ObservedValue ? 0.0 : 1.0));
            }

            else
            {
                //if queried node was not observed, than for each possible value, calculate its probability
                QueriedNode.NodeDomainValues.ForEach(value =>
                {
                    QueriedNode.ObservedValue = value;
                    var currentProb = CalculateProbability(0);
                    probabilities.Add(currentProb);
                }
                );
                QueriedNode.ObservedValue = "None";
            }

            var probsSum = probabilities.Sum();
            
            var alpha = probsSum!=0?1.0 / probsSum:0.0;
            //normalize probabilities so that their sum will be 1
            var normalizedProbs = probabilities.Select(prob => (prob * alpha)).ToList();
            return normalizedProbs;
        }
    }
}
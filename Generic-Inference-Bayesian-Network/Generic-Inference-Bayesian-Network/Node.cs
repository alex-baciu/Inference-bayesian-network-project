using System;
using System.Collections.Generic;
using System.Linq;

namespace Generic_Inference_Bayesian_Network
{
    public class Node
    {
        public long Id { get; set; }

        public String Name { get; set; }

        public int PosX { get; set; }

        public int PosY { get; set; }

        public List<long> ParentsIds { get; set; }

        public List<String> NodeDomainValues { get; set; }
        
        public String ObservedValue { get; set; }

        public Dictionary<String, List<Double>> Probabilities { get; set; }

        public Node DeepCopy()
        {
            Node newNode = (Node)this.MemberwiseClone();
            newNode.ParentsIds = new List<long>();
            newNode.ParentsIds.AddRange(this.ParentsIds);
            return newNode;
        }

        public void GenerateProbabilities(Network network)
        {
            List<List<String>> sequences = new List<List<string>>();
            List<Node> parents = new List<Node>();

            foreach (long parentId in ParentsIds)
            {
                Node parent = network.Nodes.Find(x => x.Id == parentId);
                if (parent != null)
                {
                    parents.Add(parent);
                    List<String> sequence = new List<string>();
                    parent.NodeDomainValues.ForEach(s => sequence.Add( parent.Name + "=" + s));
                    sequences.Add(sequence);
                }
            }

            if (sequences.Count == 0)
            {
                NodeDomainValues.ForEach(n => Probabilities.Add(Name + "=" + n, new List<double>() { 0.5f }));
                return;
            }

            List<String> possibilities = CartesianProduct(sequences)
              .Select(x => x.ToList().Aggregate("", (current, s) => current + " " + s))
              .ToList();

            possibilities.ForEach(p =>
            {
                List<double> values = new List<Double>();
                NodeDomainValues.ForEach(n => values.Add(0.5f));
                Probabilities.Add(p, values);
            });
        }

        private static IEnumerable<IEnumerable<String>> CartesianProduct<String>
            (IEnumerable<IEnumerable<String>> sequences)
        {
            IEnumerable<IEnumerable<String>> emptyProduct = new[] { Enumerable.Empty<String>() };
            IEnumerable<IEnumerable<String>> result = emptyProduct;
            foreach (IEnumerable<String> sequence in sequences)
            {
                result = from accseq in result from item in sequence select accseq.Concat(new[] { item });
            }
            return result;
        }

    }
}

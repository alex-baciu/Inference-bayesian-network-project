using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Generic_Inference_Bayesian_Network
{
    public partial class GenericInferenceBayesianNetwork : Form
    {
        public GenericInferenceBayesianNetwork()
        {
            InitializeComponent();
        }

        private void observeRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void queryRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            Network network = new Network();
            Node firstParent = new Node();
            Node secondParent = new Node();
            Node child = new Node();
            Node firstSonOfChild = new Node();
            Node secondSonOfChild = new Node();

            network.Name = "Network Example";
            network.Nodes = new List<Node>() { firstParent, secondParent, child, firstSonOfChild, secondSonOfChild };

            firstParent.Id = 0;
            firstParent.Name = "Gripa";
            firstParent.ParentsIds = new List<long>();
            firstParent.PosX = 50f;
            firstParent.PosY = 50f;
            firstParent.NodeDomainValues = new List<String> { "Da", "Nu" };
            firstParent.Probabilities = new Dictionary<String, List<double>>();
            firstParent.GenerateProbabilities(network);

            secondParent.Id = 1;
            secondParent.Name = "Abces";
            secondParent.ParentsIds = new List<long>();
            secondParent.PosX = 150f;
            secondParent.PosY = 50f;
            secondParent.NodeDomainValues = new List<String> { "Da", "Nu" };
            secondParent.Probabilities = new Dictionary<String, List<double>>();
            secondParent.GenerateProbabilities(network);

            child.Id = 2;
            child.Name = "Febra";
            child.ParentsIds = new List<long>() { 0, 1 };
            child.PosX = 100f;
            child.PosY = 200f;
            child.NodeDomainValues = new List<String> { "Da", "Nu" };
            child.Probabilities = new Dictionary<String, List<double>>();
            child.GenerateProbabilities(network);

            firstSonOfChild.Id = 3;
            firstSonOfChild.Name = "Oboseala";
            firstSonOfChild.ParentsIds = new List<long>() { 2 };
            firstSonOfChild.PosX = 50f;
            firstSonOfChild.PosY = 400f;
            firstSonOfChild.NodeDomainValues = new List<String> { "Da", "Nu" };
            firstSonOfChild.Probabilities = new Dictionary<String, List<double>>();
            firstSonOfChild.GenerateProbabilities(network);

            secondSonOfChild.Id = 4;
            secondSonOfChild.Name = "Anorexie";
            secondSonOfChild.ParentsIds = new List<long>() { 2 };
            secondSonOfChild.PosX = 150f;
            secondSonOfChild.PosY = 400f;
            secondSonOfChild.NodeDomainValues = new List<String> { "Da", "Nu" };
            secondSonOfChild.Probabilities = new Dictionary<String, List<double>>();
            secondSonOfChild.GenerateProbabilities(network);


            string example = JsonConvert.SerializeObject(network, Formatting.Indented);
            string filename = System.Guid.NewGuid().ToString();
            System.IO.File.WriteAllText(@".\" + filename + ".json", example);
            MessageBox.Show("Template for input is generated! " +
                "You can find it in file: " + filename + ".json",
                "Template information", MessageBoxButtons.OK);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

        }
    }
}

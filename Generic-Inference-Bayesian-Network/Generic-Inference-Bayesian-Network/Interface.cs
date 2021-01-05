using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Generic_Inference_Bayesian_Network
{
    public partial class GenericInferenceBayesianNetwork : Form
    {
        private const int NodeWitdh = 150;
        private const int NodeHeight = 60;
        private const int NodePadding = 15;

        private Network Network { get; set; }
        private int selectedAction { get; set; }
        private Dictionary<Node, TextBox> NodesTextboxes { get; set; }

        public GenericInferenceBayesianNetwork()
        {
            InitializeComponent();
            networkPictureBox.Image = new Bitmap(networkPictureBox.Width, networkPictureBox.Height);
            networkPictureBox.ClientSize = new Size(networkPictureBox.Width, networkPictureBox.Height);
            NodesTextboxes = new Dictionary<Node, TextBox>();
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
            firstParent.PosX = 50;
            firstParent.PosY = 50;
            firstParent.NodeDomainValues = new List<String> { "Da", "Nu" };
            firstParent.ObservedValue = "None";
            firstParent.Probabilities = new Dictionary<String, List<double>>();
            firstParent.GenerateProbabilities(network);

            secondParent.Id = 1;
            secondParent.Name = "Abces";
            secondParent.ParentsIds = new List<long>();
            secondParent.PosX = 250;
            secondParent.PosY = 50;
            secondParent.NodeDomainValues = new List<String> { "Da", "Nu" };
            secondParent.ObservedValue = "None";
            secondParent.Probabilities = new Dictionary<String, List<double>>();
            secondParent.GenerateProbabilities(network);

            child.Id = 2;
            child.Name = "Febra";
            child.ParentsIds = new List<long>() { 0, 1 };
            child.PosX = 150;
            child.PosY = 200;
            child.NodeDomainValues = new List<String> { "Da", "Nu" };
            child.ObservedValue = "None";
            child.Probabilities = new Dictionary<String, List<double>>();
            child.GenerateProbabilities(network);

            firstSonOfChild.Id = 3;
            firstSonOfChild.Name = "Oboseala";
            firstSonOfChild.ParentsIds = new List<long>() { 2 };
            firstSonOfChild.PosX = 50;
            firstSonOfChild.PosY = 400;
            firstSonOfChild.NodeDomainValues = new List<String> { "Da", "Nu" };
            firstSonOfChild.ObservedValue = "None";
            firstSonOfChild.Probabilities = new Dictionary<String, List<double>>();
            firstSonOfChild.GenerateProbabilities(network);

            secondSonOfChild.Id = 4;
            secondSonOfChild.Name = "Anorexie";
            secondSonOfChild.ParentsIds = new List<long>() { 2 };
            secondSonOfChild.PosX = 250;
            secondSonOfChild.PosY = 400;
            secondSonOfChild.NodeDomainValues = new List<String> { "Da", "Nu" };
            secondSonOfChild.ObservedValue = "None";
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
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select input network json file",
                Filter = "Json files (*.json)|*.json"
            };

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {   
                foreach (KeyValuePair<Node, TextBox> entry in NodesTextboxes)
                {
                    networkPictureBox.Controls.Remove(entry.Value);
                }

                Network = JsonConvert.DeserializeObject<Network>(File.ReadAllText(openFileDialog.FileName));
                NodesTextboxes = new Dictionary<Node, TextBox>();
                networkPictureBox.Image = new Bitmap(networkPictureBox.Width, networkPictureBox.Height);
                networkPictureBox.Refresh();

                Network.Nodes.ForEach(n =>
                {
                    DrawNode(n);
                    if (n.ParentsIds.Count != 0)
                    {
                        DrawArrow(n);
                    }
                });
            }
        }

        private void DrawNode(Node node)
        {
            using (Graphics G = Graphics.FromImage(networkPictureBox.Image))
            {
                Pen pen = new Pen(Color.Black, 3);
                TextBox t = new TextBox();

                t.Location = new System.Drawing.Point(node.PosX + NodePadding, node.PosY + NodePadding);
                t.Text = node.Name +"\r\n(None)";
                t.Multiline = true;
                t.Width = NodeWitdh - 2 * NodePadding;
                t.Height = NodeHeight - 2 * NodePadding;
                t.BackColor = Color.White;
                t.ForeColor = Color.Black;
                t.Visible = true;
                t.BorderStyle = BorderStyle.None;
                t.TextAlign = HorizontalAlignment.Center;
                t.Enabled = false;
                networkPictureBox.Controls.Add(t);
                NodesTextboxes.Add(node, t);

                G.DrawEllipse(pen, new Rectangle(node.PosX, node.PosY, NodeWitdh, NodeHeight));
            }

            networkPictureBox.Refresh();
        }

        private void DrawArrow(Node child)
        {
            using (Graphics G = Graphics.FromImage(networkPictureBox.Image))
            {
                Pen pen = new Pen(Color.Black, 4);
                int startX, startY, endX, endY;

                foreach (int id in child.ParentsIds)
                {
                    Node parent = Network.Nodes.Find(n => n.Id == id);
                    pen.EndCap = LineCap.ArrowAnchor;

                    switch (GetDirection(parent, child))
                    {
                        case EDirection.RIGHT:
                            startX = parent.PosX;
                            startY = parent.PosY + NodeHeight / 2;
                            endX = child.PosX + NodeWitdh;
                            endY = child.PosY + NodeHeight / 2;
                            break;
                        case EDirection.LEFT:
                            startX = parent.PosX + NodeWitdh;
                            startY = parent.PosY + NodeHeight / 2;
                            endX = child.PosX;
                            endY = child.PosY + NodeHeight / 2;
                            break;
                        case EDirection.UP:
                            startX = parent.PosX + NodeWitdh / 2;
                            startY = parent.PosY + NodeHeight;
                            endX = child.PosX + NodeWitdh / 2;
                            endY = child.PosY;
                            break;
                        case EDirection.DOWN:
                            startX = parent.PosX + NodeWitdh / 2;
                            startY = parent.PosY;
                            endX = child.PosX + NodeWitdh / 2;
                            endY = child.PosY + NodeHeight;
                            break;
                        default:
                            MessageBox.Show("Error!", " You have nodes very close to each other", MessageBoxButtons.OK);
                            throw new Exception("Bad nodes coordinates. Update json file!");
                    }

                    G.DrawLine(pen, startX, startY, endX, endY);
                }
            }

            networkPictureBox.Refresh();
        }

        private EDirection GetDirection(Node parent, Node Child)
        {
            if (parent.PosX < Child.PosX && parent.PosY >= Child.PosY && parent.PosY <= Child.PosY + Height)
            {
                return EDirection.LEFT;
            }

            if (parent.PosX > Child.PosX + NodeWitdh && parent.PosY >= Child.PosY && parent.PosY <= Child.PosY + Height)
            {
                return EDirection.RIGHT;
            }

            if (parent.PosY < Child.PosY)
            {
                return EDirection.UP;
            }

            if (parent.PosY > Child.PosY + NodeHeight)
            {
                return EDirection.DOWN;
            }

            return EDirection.NONE;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<Node, TextBox> entry in NodesTextboxes)
            {
                entry.Value.Text = entry.Key.Name + "\r\n(None)";
            }

            foreach(Node node in Network.Nodes)
            {
                node.ObservedValue = "None";
            }
        }

        private void OpenMenu(Node node)
        {
            Form menu = new Form();
            menu.Text = "Observe node " + node.Name;
            int startX = 25, startY = 25;
            RadioButton r;
            TextBox t = NodesTextboxes[node];

            foreach (String domainValue in node.NodeDomainValues)
            {
                r = new RadioButton();
                r.Location = new Point(startX, startY);
                r.Text = domainValue;
                if (t.Text.Contains($"({r.Text})"))
                {
                    r.Checked = true;
                }
                r.CheckedChanged += (sender, e) =>
                {  
                    t.Text = node.Name + "\r\n(" + domainValue + ")";
                    node.ObservedValue = domainValue;
                };
                menu.Controls.Add(r);
                startY += 30;
            }

            r = new RadioButton();
            r.Location = new Point(startX, startY);
            r.Text = "None";
            if (t.Text.Contains($"({r.Text})"))
            {
                r.Checked = true;
            }
            r.CheckedChanged += (sender, e) =>
            {              
                t.Text = node.Name + "\r\n(None)";
                node.ObservedValue = "None";
            };
            menu.Controls.Add(r);
            menu.Show();
        }

        private void networkPictureBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            Point coordinates = click.Location;
            Node pressedNode = null;
            if (Network == null)
                return;

            for (int i = 0; i < Network.Nodes.Count; i++)
            {
                Node node = Network.Nodes[i];

                if (coordinates.X >= node.PosX + NodePadding && coordinates.X <= node.PosX + NodeWitdh - NodePadding &&
                coordinates.Y >= node.PosY + NodePadding && coordinates.Y <= node.PosY + NodeHeight - NodePadding)
                {
                    pressedNode = node;
                    if (observeRadioButton.Checked == true)
                    {
                        OpenMenu(node);
                    }
                    else
                    {

                        InferenceByEnumeration inferenceByEnumeration = new InferenceByEnumeration
                        {
                            Network = Network,
                            QueriedNode = node
                        };
                        var results = inferenceByEnumeration.CalculateProbabilities();

                        //show results
                        var text = $"Query results for Variable {node.Name} [";

                        var observedNodes = Network.Nodes.FindAll(it => it.ObservedValue != "None")
                            .Select(it => $"{it.Name}={it.ObservedValue}");

                        text += string.Join(", ", observedNodes);
                        text += "]:\r\n\r\n";

                        node.NodeDomainValues
                            .Select((val, index) => $"\tP({node.Name}={val})={Math.Round(results[index], 5)}\r\n"
                        ).ToList()
                        .ForEach(it => text += $"{it}\r\n");

                        MessageBox.Show(text, "Query Results");

                    }
                    break;
                }
            }
        }
    }
}

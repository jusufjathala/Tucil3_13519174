using Microsoft.Msagl.Drawing;
using System;
using System.Collections.Generic;

using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace Tucil3
{
    public partial class Form1 : Form
    {

        private List<string> listNames;
        private List<Tuple<Stack<int>, double>> listTuples;
        private List<Node> listNodes;
        private WeightedGraph myGraph;
        //visited
        private bool[] visited;

        public Form1()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog2_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = "./",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                FileName = textBox1.Text;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void viewer1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string text1 = File.ReadAllText(FileName);

                listNames = new List<string>();
                listTuples = new List<Tuple<Stack<int>, double>>();
                listNodes = new List<Node>();
                
                graph1 = new Microsoft.Msagl.Drawing.Graph("graph");

                char[] delimiterLine = { '\n' };
                char[] delimiterSlash = { '/' };
                char[] delimiterComma = { ',' };
                string[] delimiterDot = { "\n." };

                //pisahkan koordinat dan matrix
                string[] split = text1.Split(delimiterDot, StringSplitOptions.RemoveEmptyEntries); 

                string[] lines = split[0].Split(delimiterLine); //split setiap newline

                for (int i = 1; i <= Int32.Parse(lines[0]); i++)
                {
                    string[] name = lines[i].Split(delimiterSlash);
                    string[] coord = name[1].Split(delimiterComma);
                    if (!listNames.Contains(name[0]))
                    {
                        //Menambahkan simpul ke list nama dan list simpul
                        listNames.Add(name[0]);
                        Node n = new Node(listNames.IndexOf(name[0]), Int32.Parse(coord[0]), Int32.Parse(coord[1]));
                        listNodes.Add(n);
                    }
                }

                string[] matrix = split[1].Split(delimiterLine);
                myGraph = new WeightedGraph(Int32.Parse(lines[0]));

                //Menambahkan ketetanggaan simpul dan menggambar visualisasi Graf
                for (int i = 1; i <= Int32.Parse(lines[0]); i++)
                {

                    string copy = matrix[i];
                    for (int j = i; j <= Int32.Parse(lines[0]); j++)
                    {
                        if (copy[j].Equals('1'))
                        {
                            Edge ed = new Edge(listNodes[i - 1], listNodes[j - 1]);
                            myGraph.AddEdge(ed);

                            string node1;
                            string node2;
                            node1 = matrix[0].Substring(i, 1);
                            node2 = matrix[0].Substring(j, 1);
                            var Edge = graph1.AddEdge(node1, node2);
                            Edge.Attr.ArrowheadAtTarget = ArrowStyle.None;
                            Edge.Attr.ArrowheadAtSource = ArrowStyle.None;

                            graph1.FindNode(node1).Attr.FillColor = Microsoft.Msagl.Drawing.Color.MistyRose;
                            graph1.FindNode(node2).Attr.FillColor = Microsoft.Msagl.Drawing.Color.MistyRose;

                        }
                    }
                }



                gViewer1.Graph = graph1;
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox1.Items.AddRange(listNames.ToArray());
                comboBox2.Items.AddRange(listNames.ToArray());
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Please Input an acceptable file", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Items.Count == 0)
                {
                    MessageBox.Show("Please click visualize first", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (comboBox1.Text.Equals("") || comboBox2.Text.Equals(""))
                {
                    MessageBox.Show("Please select node first", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (comboBox1.Text.Equals(comboBox2.Text))
                {
                    MessageBox.Show("Cannot select same node", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Size newSize;
                newSize = new Size(Size.Width, 733);
                richTextBox1.BorderStyle = BorderStyle.FixedSingle;
                this.Size = newSize;
                Point newLoc = new Point(0, 0);
                this.Location = newLoc;
                string richboxtext1 = "Simpul Sumber: " + comboBox1.SelectedItem + "\n" + "Simpul Target: " + comboBox2.SelectedItem + "\n";

                //Array visited
                visited = new bool[myGraph.V()];
                for (int i = 0; i < myGraph.V(); i++)
                {
                    visited[i] = false;
                }

                //isource adalah index simpul sumber dan ifind adalah index simpul tujuan
                int isource = comboBox1.SelectedIndex;
                int ifind = comboBox2.SelectedIndex;

                //Push simpul sumber
                Stack<int> start = new Stack<int>();
                start.Push(isource);

                listTuples.Clear();
                listTuples.Add(Tuple.Create(start, Convert.ToDouble(0)));

                int v = listTuples[0].Item1.Peek();
                visited[v] = true;
                int visitedcount = 1;

                while (listTuples.Count > 0 && visitedcount < myGraph.V() && v != ifind)
                {
                    //jika bukan memeriksa simpul awal akan mengganti tuple awal dengan
                    //tuple yang memiliki f(n) dikurangi jarak heuristik
                    if (listTuples[0].Item2 != 0)
                    {
                        Stack<int> temp1 = new Stack<int>(listTuples[0].Item1.Reverse());
                        double temp2 = listTuples[0].Item2 - listNodes[listTuples[0].Item1.Peek()].EuclideanDistance(listNodes[ifind]);
                        listTuples.Insert(1, Tuple.Create(temp1, temp2));
                        listTuples.RemoveAt(0);
                    }

                    //memeriksa simpul yang terhubung dengan simpul sumber
                    foreach (var edge in myGraph.getAdjacency(v))
                    {
                        if (!visited[edge.Target(listNodes[v]).V()])
                        {
                            visited[edge.Target(listNodes[v]).V()] = true;
                            visitedcount++;
                            Stack<int> s = new Stack<int>(listTuples[0].Item1.Reverse());
                            s.Push(edge.Target(listNodes[v]).V());

                            double fn = 0;
                            double eucli = edge.Target(listNodes[v]).EuclideanDistance(listNodes[ifind]);
                            fn = listTuples[0].Item2 + edge.Weight() + eucli;

                            listTuples.Add(Tuple.Create(s, fn));
                        }
                    }


                    //melakukan sort list tuple
                    listTuples.Sort((x, y) => x.Item2.CompareTo(y.Item2));
                    if (listTuples[0].Item1.Peek() != ifind)
                    {
                        listTuples.RemoveAt(0);
                    }

                    v = listTuples[0].Item1.Peek();

                }

                richboxtext1 = richboxtext1 + "Didapatkan Jalur: " + "\n";
                richboxtext1 = richboxtext1 + printStack(listTuples[0].Item1, listNames);
                richboxtext1 = richboxtext1 + "Dengan Jarak: " + "\n";
                richboxtext1 = richboxtext1 + string.Format("{0:N4}", listTuples[0].Item2) + " meter\n";

                Stack<int> stackPath = new Stack<int>(listTuples[0].Item1);

                RefreshGraphColor(listNames);

                //memberi warna pada simpul graf
                System.Drawing.Color colorname = System.Drawing.Color.FromName("Cyan");
                graph1.FindNode(listNames.ElementAt(isource)).Attr.FillColor = new Microsoft.Msagl.Drawing.Color(colorname.R, colorname.G, colorname.B);

                while (stackPath.Count > 0)
                {
                    graph1.FindNode(listNames.ElementAt(stackPath.Pop())).Attr.FillColor = new Microsoft.Msagl.Drawing.Color(colorname.R, colorname.G, colorname.B);
                }
                //refresh graph
                gViewer1.Graph = graph1;


                richTextBox1.Text = richboxtext1;
            }
            catch
            {
                MessageBox.Show("Some error happened.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void RefreshGraphColor(List<string> listNames)
        {
            for (int i = 0; i < listNames.Count; i++)
            {
                graph1.FindNode(listNames[i]).Attr.FillColor = Microsoft.Msagl.Drawing.Color.MistyRose;
            }
        }
        private static string printStack(Stack<int> stack, List<string> listNames)
        {
            StringBuilder build = new StringBuilder();
            build.Append("Jalur : ");
            Stack<int> temp = new Stack<int>(stack);
            while (temp.Count > 0)
            {
                build.Append(listNames[temp.Pop()]);
                if (temp.Count != 0)
                {
                    build.Append("->");
                }
                else
                {
                    build.Append("\n");
                }
            }
            return build.ToString();
        }



        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

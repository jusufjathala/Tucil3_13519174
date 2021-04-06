
using System.Drawing;

namespace Tucil3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private string FileName;
        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gViewer1 = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Browse File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(47, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(224, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Tag = "FileName";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(116, 8);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(180, 16);
            this.textBox2.TabIndex = 2;
            this.textBox2.Tag = "";
            this.textBox2.Text = "Please Select Formatted File First ";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // gViewer1
            // 
            this.gViewer1.ArrowheadLength = 10D;
            this.gViewer1.AsyncLayout = false;
            this.gViewer1.AutoScroll = true;
            this.gViewer1.AutoSize = true;
            this.gViewer1.BackColor = System.Drawing.Color.Plum;
            this.gViewer1.BackwardEnabled = false;
            this.gViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gViewer1.BuildHitTree = true;
            this.gViewer1.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
            this.gViewer1.EdgeInsertButtonVisible = true;
            this.gViewer1.FileName = "";
            this.gViewer1.ForwardEnabled = false;
            this.gViewer1.Graph = null;
            this.gViewer1.InsertingEdge = false;
            this.gViewer1.LayoutAlgorithmSettingsButtonVisible = true;
            this.gViewer1.LayoutEditingEnabled = true;
            this.gViewer1.Location = new System.Drawing.Point(27, 88);
            this.gViewer1.LooseOffsetForRouting = 0.25D;
            this.gViewer1.MouseHitDistance = 0.05D;
            this.gViewer1.Name = "gViewer1";
            this.gViewer1.NavigationVisible = true;
            this.gViewer1.NeedToCalculateLayout = true;
            this.gViewer1.OffsetForRelaxingInRouting = 0.6D;
            this.gViewer1.PaddingForEdgeRouting = 1.5D;
            this.gViewer1.PanButtonPressed = false;
            this.gViewer1.SaveAsImageEnabled = true;
            this.gViewer1.SaveAsMsaglEnabled = true;
            this.gViewer1.SaveButtonVisible = true;
            this.gViewer1.SaveGraphButtonVisible = true;
            this.gViewer1.SaveInVectorFormatEnabled = true;
            this.gViewer1.Size = new System.Drawing.Size(369, 211);
            this.gViewer1.TabIndex = 3;
            this.gViewer1.TightOffsetForRouting = 0.125D;
            this.gViewer1.ToolBarIsVisible = true;
            this.gViewer1.Transform = ((Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation)(resources.GetObject("gViewer1.Transform")));
            this.gViewer1.UndoRedoButtonsVisible = true;
            this.gViewer1.WindowZoomButtonPressed = false;
            this.gViewer1.ZoomF = 1.5535019005577762D;
            this.gViewer1.ZoomWindowThreshold = 0.05D;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Visualized";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.richTextBox1.Location = new System.Drawing.Point(27, 482);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(369, 200);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(158, 330);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(113, 23);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(27, 333);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(111, 16);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "Choose Node Source";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(27, 359);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(111, 16);
            this.textBox5.TabIndex = 11;
            this.textBox5.Text = "Choose Node Target";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(158, 359);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(113, 23);
            this.comboBox2.Sorted = true;
            this.comboBox2.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(144, 359);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(8, 16);
            this.textBox6.TabIndex = 13;
            this.textBox6.Text = ":";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(144, 333);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(10, 16);
            this.textBox7.TabIndex = 14;
            this.textBox7.Text = ":";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 31);
            this.button3.TabIndex = 15;
            this.button3.Text = "SUBMIT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.richTextBox2.BackColor = System.Drawing.Color.LavenderBlush;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Location = new System.Drawing.Point(27, 430);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(369, 46);
            this.richTextBox2.TabIndex = 16;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(422, 431);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gViewer1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Tag = "";
            this.Text = "Tucil 3 Stima";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Msagl.Drawing.Graph graph1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private Microsoft.Msagl.GraphViewerGdi.GViewer gViewer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}


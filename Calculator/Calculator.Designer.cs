namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.equal = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.middle = new System.Windows.Forms.Label();
            this.CE = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // equal
            // 
            this.equal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.equal.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.equal, 4);
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.equal.Location = new System.Drawing.Point(3, 278);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(231, 53);
            this.equal.TabIndex = 2;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.calculate);
            this.equal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PressKeys);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Controls.Add(this.equal, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.middle, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.CE, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.one, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.four, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.zero, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.two, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.dot, 2, 4);
            this.tableLayoutPanel.Controls.Add(this.three, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.div, 3, 4);
            this.tableLayoutPanel.Controls.Add(this.mult, 3, 3);
            this.tableLayoutPanel.Controls.Add(this.minus, 3, 2);
            this.tableLayoutPanel.Controls.Add(this.six, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.five, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.plus, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.nine, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.eight, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.seven, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.display, 2, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(237, 334);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // middle
            // 
            this.tableLayoutPanel.SetColumnSpan(this.middle, 2);
            this.middle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.middle.Location = new System.Drawing.Point(3, 0);
            this.middle.Name = "middle";
            this.middle.Size = new System.Drawing.Size(112, 55);
            this.middle.TabIndex = 3;
            this.middle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CE
            // 
            this.CE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CE.AutoSize = true;
            this.CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CE.Location = new System.Drawing.Point(3, 223);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(53, 49);
            this.CE.TabIndex = 12;
            this.CE.TabStop = false;
            this.CE.Tag = "del";
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = true;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            this.CE.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PressKeys);
            // 
            // one
            // 
            this.one.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.one.AutoSize = true;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.one.Location = new System.Drawing.Point(3, 168);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(53, 49);
            this.one.TabIndex = 8;
            this.one.TabStop = false;
            this.one.Tag = "1";
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.DigitClick);
            this.one.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PressKeys);
            // 
            // four
            // 
            this.four.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.four.AutoSize = true;
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.four.Location = new System.Drawing.Point(3, 113);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(53, 49);
            this.four.TabIndex = 4;
            this.four.TabStop = false;
            this.four.Tag = "4";
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.DigitClick);
            this.four.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PressKeys);
            // 
            // zero
            // 
            this.zero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zero.AutoSize = true;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.zero.Location = new System.Drawing.Point(62, 223);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(53, 49);
            this.zero.TabIndex = 13;
            this.zero.TabStop = false;
            this.zero.Tag = "0";
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.DigitClick);
            this.zero.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PressKeys);
            // 
            // two
            // 
            this.two.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.two.AutoSize = true;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.two.Location = new System.Drawing.Point(62, 168);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(53, 49);
            this.two.TabIndex = 9;
            this.two.TabStop = false;
            this.two.Tag = "2";
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.DigitClick);
            this.two.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PressKeys);
            // 
            // dot
            // 
            this.dot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dot.AutoSize = true;
            this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dot.Location = new System.Drawing.Point(121, 223);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(53, 49);
            this.dot.TabIndex = 14;
            this.dot.TabStop = false;
            this.dot.Tag = ".";
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            this.dot.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PressKeys);
            // 
            // three
            // 
            this.three.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.three.AutoSize = true;
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.three.Location = new System.Drawing.Point(121, 168);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(53, 49);
            this.three.TabIndex = 10;
            this.three.TabStop = false;
            this.three.Tag = "3";
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.DigitClick);
            this.three.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PressKeys);
            // 
            // div
            // 
            this.div.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.div.AutoSize = true;
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.div.Location = new System.Drawing.Point(180, 223);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(54, 49);
            this.div.TabIndex = 15;
            this.div.TabStop = false;
            this.div.Tag = "/";
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.OperationClick);
            this.div.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PressKeys);
            // 
            // mult
            // 
            this.mult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mult.AutoSize = true;
            this.mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.mult.Location = new System.Drawing.Point(180, 168);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(54, 49);
            this.mult.TabIndex = 11;
            this.mult.TabStop = false;
            this.mult.Tag = "*";
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.OperationClick);
            this.mult.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PressKeys);
            // 
            // minus
            // 
            this.minus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minus.AutoSize = true;
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.minus.Location = new System.Drawing.Point(180, 113);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(54, 49);
            this.minus.TabIndex = 7;
            this.minus.TabStop = false;
            this.minus.Tag = "-";
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.OperationClick);
            this.minus.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PressKeys);
            // 
            // six
            // 
            this.six.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.six.AutoSize = true;
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.six.Location = new System.Drawing.Point(121, 113);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(53, 49);
            this.six.TabIndex = 6;
            this.six.TabStop = false;
            this.six.Tag = "6";
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.DigitClick);
            this.six.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PressKeys);
            // 
            // five
            // 
            this.five.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.five.AutoSize = true;
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.five.Location = new System.Drawing.Point(62, 113);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(53, 49);
            this.five.TabIndex = 5;
            this.five.TabStop = false;
            this.five.Tag = "5";
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.DigitClick);
            this.five.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PressKeys);
            // 
            // plus
            // 
            this.plus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plus.AutoSize = true;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.plus.Location = new System.Drawing.Point(180, 58);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(54, 49);
            this.plus.TabIndex = 3;
            this.plus.TabStop = false;
            this.plus.Tag = "+";
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.OperationClick);
            this.plus.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PressKeys);
            // 
            // nine
            // 
            this.nine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nine.AutoSize = true;
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.nine.Location = new System.Drawing.Point(121, 58);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(53, 49);
            this.nine.TabIndex = 2;
            this.nine.TabStop = false;
            this.nine.Tag = "9";
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.DigitClick);
            this.nine.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PressKeys);
            // 
            // eight
            // 
            this.eight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eight.AutoSize = true;
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.eight.Location = new System.Drawing.Point(62, 58);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(53, 49);
            this.eight.TabIndex = 1;
            this.eight.TabStop = false;
            this.eight.Tag = "8";
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.DigitClick);
            this.eight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PressKeys);
            // 
            // seven
            // 
            this.seven.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seven.AutoSize = true;
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.seven.Location = new System.Drawing.Point(3, 58);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(53, 49);
            this.seven.TabIndex = 0;
            this.seven.TabStop = false;
            this.seven.Tag = "7";
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.DigitClick);
            this.seven.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PressKeys);
            // 
            // display
            // 
            this.display.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.display.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel.SetColumnSpan(this.display, 2);
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.display.Location = new System.Drawing.Point(121, 0);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(113, 55);
            this.display.TabIndex = 0;
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 334);
            this.Controls.Add(this.tableLayoutPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(437, 573);
            this.MinimumSize = new System.Drawing.Size(253, 373);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Label display;
        private System.Windows.Forms.Label middle;
    }
}


namespace ShoppingCart
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            chbCoffee = new CheckBox();
            chbGreentea = new CheckBox();
            label1 = new Label();
            button1 = new Button();
            tbCoffeePrice = new TextBox();
            tbGreenTeaPrice = new TextBox();
            tbTotal = new TextBox();
            tbCoffeeQuantity = new TextBox();
            tbGreenTeaQuantity = new TextBox();
            SuspendLayout();
            // 
            // chbCoffee
            // 
            chbCoffee.AutoSize = true;
            chbCoffee.Location = new Point(120, 23);
            chbCoffee.Name = "chbCoffee";
            chbCoffee.Size = new Size(61, 19);
            chbCoffee.TabIndex = 0;
            chbCoffee.Text = "Coffee";
            chbCoffee.UseVisualStyleBackColor = true;
            // 
            // chbGreentea
            // 
            chbGreentea.AutoSize = true;
            chbGreentea.Location = new Point(120, 48);
            chbGreentea.Name = "chbGreentea";
            chbGreentea.Size = new Size(78, 19);
            chbGreentea.TabIndex = 1;
            chbGreentea.Text = "Green Tea";
            chbGreentea.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(313, 132);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 2;
            label1.Text = "Total";
            label1.Click += but;
            // 
            // button1
            // 
            button1.Location = new Point(504, 28);
            button1.Name = "button1";
            button1.Size = new Size(75, 124);
            button1.TabIndex = 3;
            button1.Text = "Check out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbCoffeePrice
            // 
            tbCoffeePrice.Location = new Point(246, 21);
            tbCoffeePrice.Name = "tbCoffeePrice";
            tbCoffeePrice.Size = new Size(100, 23);
            tbCoffeePrice.TabIndex = 4;
            // 
            // tbGreenTeaPrice
            // 
            tbGreenTeaPrice.Location = new Point(246, 50);
            tbGreenTeaPrice.Name = "tbGreenTeaPrice";
            tbGreenTeaPrice.Size = new Size(100, 23);
            tbGreenTeaPrice.TabIndex = 5;
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(375, 124);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(100, 23);
            tbTotal.TabIndex = 6;
            // 
            // tbCoffeeQuantity
            // 
            tbCoffeeQuantity.Location = new Point(375, 19);
            tbCoffeeQuantity.Name = "tbCoffeeQuantity";
            tbCoffeeQuantity.Size = new Size(100, 23);
            tbCoffeeQuantity.TabIndex = 7;
            // 
            // tbGreenTeaQuantity
            // 
            tbGreenTeaQuantity.Location = new Point(375, 50);
            tbGreenTeaQuantity.Name = "tbGreenTeaQuantity";
            tbGreenTeaQuantity.Size = new Size(100, 23);
            tbGreenTeaQuantity.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 222);
            Controls.Add(tbGreenTeaQuantity);
            Controls.Add(tbCoffeeQuantity);
            Controls.Add(tbTotal);
            Controls.Add(tbGreenTeaPrice);
            Controls.Add(tbCoffeePrice);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(chbGreentea);
            Controls.Add(chbCoffee);
            Name = "Form1";
            Text = "Chan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chbCoffee;
        private CheckBox chbGreentea;
        private Label label1;
        private Button button1;
        private TextBox tbCoffeePrice;
        private TextBox tbGreenTeaPrice;
        private TextBox tbTotal;
        private TextBox tbCoffeeQuantity;
        private TextBox tbGreenTeaQuantity;
    }
}

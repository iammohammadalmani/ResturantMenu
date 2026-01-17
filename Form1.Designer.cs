namespace OOPlabProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            resturantName = new Label();
            label1 = new Label();
            Appetizers = new Button();
            mainCourses = new Button();
            desserts = new Button();
            drinks = new Button();
            SuspendLayout();
            // 
            // resturantName
            // 
            resturantName.AutoSize = true;
            resturantName.BackColor = Color.Transparent;
            resturantName.Font = new Font("Segoe Script", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resturantName.Location = new Point(60, 9);
            resturantName.Name = "resturantName";
            resturantName.Size = new Size(471, 57);
            resturantName.TabIndex = 0;
            resturantName.Text = "White Palm's Resturant";
            resturantName.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Script", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(237, 61);
            label1.Name = "label1";
            label1.Size = new Size(130, 57);
            label1.TabIndex = 1;
            label1.Text = "menu";
            // 
            // Appetizers
            // 
            Appetizers.Font = new Font("Segoe Script", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Appetizers.Location = new Point(202, 135);
            Appetizers.Name = "Appetizers";
            Appetizers.Size = new Size(200, 50);
            Appetizers.TabIndex = 2;
            Appetizers.Text = "Appetizers";
            Appetizers.UseVisualStyleBackColor = true;
            Appetizers.Click += Appetizers_Click;
            // 
            // mainCourses
            // 
            mainCourses.Font = new Font("Segoe Script", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainCourses.Location = new Point(202, 219);
            mainCourses.Name = "mainCourses";
            mainCourses.Size = new Size(200, 50);
            mainCourses.TabIndex = 3;
            mainCourses.Text = "Main Course";
            mainCourses.UseVisualStyleBackColor = true;
            mainCourses.Click += mainCourses_Click;
            // 
            // desserts
            // 
            desserts.Font = new Font("Segoe Script", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            desserts.Location = new Point(202, 300);
            desserts.Name = "desserts";
            desserts.Size = new Size(200, 50);
            desserts.TabIndex = 4;
            desserts.Text = "Desserts";
            desserts.UseVisualStyleBackColor = true;
            desserts.Click += desserts_Click;
            // 
            // drinks
            // 
            drinks.Font = new Font("Segoe Script", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            drinks.Location = new Point(202, 382);
            drinks.Name = "drinks";
            drinks.Size = new Size(200, 50);
            drinks.TabIndex = 5;
            drinks.Text = "Drinks";
            drinks.UseVisualStyleBackColor = true;
            drinks.Click += drinks_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(607, 466);
            Controls.Add(drinks);
            Controls.Add(desserts);
            Controls.Add(mainCourses);
            Controls.Add(Appetizers);
            Controls.Add(label1);
            Controls.Add(resturantName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label resturantName;
        private Label label1;
        private Button Appetizers;
        private Button mainCourses;
        private Button desserts;
        private Button drinks;
    }
}

namespace FormUI
{
  partial class linq101DemoForm
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      this.linq101DemoLabel = new System.Windows.Forms.Label();
      this.filteredListListbox = new System.Windows.Forms.ListBox();
      this.allPeopleCombobox = new System.Windows.Forms.ComboBox();
      this.yearsExperienceNumericupdown = new System.Windows.Forms.NumericUpDown();
      this.updateButton = new System.Windows.Forms.Button();
      this.allPeopleLabel = new System.Windows.Forms.Label();
      this.yearsExperienceLabel = new System.Windows.Forms.Label();
      this.filteredListLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.yearsExperienceNumericupdown)).BeginInit();
      this.SuspendLayout();
      // 
      // linq101DemoLabel
      // 
      this.linq101DemoLabel.AutoSize = true;
      this.linq101DemoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.linq101DemoLabel.Location = new System.Drawing.Point(57, 24);
      this.linq101DemoLabel.Name = "linq101DemoLabel";
      this.linq101DemoLabel.Size = new System.Drawing.Size(188, 29);
      this.linq101DemoLabel.TabIndex = 0;
      this.linq101DemoLabel.Text = "Linq 101 Demo";
      // 
      // filteredListListbox
      // 
      this.filteredListListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.filteredListListbox.FormattingEnabled = true;
      this.filteredListListbox.ItemHeight = 24;
      this.filteredListListbox.Location = new System.Drawing.Point(385, 123);
      this.filteredListListbox.Name = "filteredListListbox";
      this.filteredListListbox.Size = new System.Drawing.Size(337, 220);
      this.filteredListListbox.TabIndex = 1;
      // 
      // allPeopleCombobox
      // 
      this.allPeopleCombobox.FormattingEnabled = true;
      this.allPeopleCombobox.Location = new System.Drawing.Point(62, 123);
      this.allPeopleCombobox.Name = "allPeopleCombobox";
      this.allPeopleCombobox.Size = new System.Drawing.Size(204, 21);
      this.allPeopleCombobox.TabIndex = 2;
      this.allPeopleCombobox.SelectedIndexChanged += new System.EventHandler(this.allPeopleCombobox_SelectedIndexChanged);
      // 
      // yearsExperienceNumericupdown
      // 
      this.yearsExperienceNumericupdown.Location = new System.Drawing.Point(62, 223);
      this.yearsExperienceNumericupdown.Name = "yearsExperienceNumericupdown";
      this.yearsExperienceNumericupdown.Size = new System.Drawing.Size(204, 20);
      this.yearsExperienceNumericupdown.TabIndex = 3;
      // 
      // updateButton
      // 
      this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.updateButton.Location = new System.Drawing.Point(131, 284);
      this.updateButton.Name = "updateButton";
      this.updateButton.Size = new System.Drawing.Size(114, 45);
      this.updateButton.TabIndex = 4;
      this.updateButton.Text = "Update";
      this.updateButton.UseVisualStyleBackColor = true;
      this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
      // 
      // allPeopleLabel
      // 
      this.allPeopleLabel.AutoSize = true;
      this.allPeopleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.allPeopleLabel.Location = new System.Drawing.Point(62, 89);
      this.allPeopleLabel.Name = "allPeopleLabel";
      this.allPeopleLabel.Size = new System.Drawing.Size(95, 24);
      this.allPeopleLabel.TabIndex = 5;
      this.allPeopleLabel.Text = "All people";
      // 
      // yearsExperienceLabel
      // 
      this.yearsExperienceLabel.AutoSize = true;
      this.yearsExperienceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.yearsExperienceLabel.Location = new System.Drawing.Point(58, 186);
      this.yearsExperienceLabel.Name = "yearsExperienceLabel";
      this.yearsExperienceLabel.Size = new System.Drawing.Size(159, 24);
      this.yearsExperienceLabel.TabIndex = 6;
      this.yearsExperienceLabel.Text = "Years experience";
      // 
      // filteredListLabel
      // 
      this.filteredListLabel.AutoSize = true;
      this.filteredListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.filteredListLabel.Location = new System.Drawing.Point(452, 89);
      this.filteredListLabel.Name = "filteredListLabel";
      this.filteredListLabel.Size = new System.Drawing.Size(99, 24);
      this.filteredListLabel.TabIndex = 7;
      this.filteredListLabel.Text = "Filtered list";
      // 
      // linq101DemoForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.filteredListLabel);
      this.Controls.Add(this.yearsExperienceLabel);
      this.Controls.Add(this.allPeopleLabel);
      this.Controls.Add(this.updateButton);
      this.Controls.Add(this.yearsExperienceNumericupdown);
      this.Controls.Add(this.allPeopleCombobox);
      this.Controls.Add(this.filteredListListbox);
      this.Controls.Add(this.linq101DemoLabel);
      this.Name = "linq101DemoForm";
      this.Text = "Linq 101 Demo";
      ((System.ComponentModel.ISupportInitialize)(this.yearsExperienceNumericupdown)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label linq101DemoLabel;
    private System.Windows.Forms.ListBox filteredListListbox;
    private System.Windows.Forms.ComboBox allPeopleCombobox;
    private System.Windows.Forms.NumericUpDown yearsExperienceNumericupdown;
    private System.Windows.Forms.Button updateButton;
    private System.Windows.Forms.Label allPeopleLabel;
    private System.Windows.Forms.Label yearsExperienceLabel;
    private System.Windows.Forms.Label filteredListLabel;
  }
}


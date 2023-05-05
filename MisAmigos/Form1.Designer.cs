
namespace MisAmigos
{
   partial class MisAmigos
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
         this.amigosListBox = new System.Windows.Forms.ListBox();
         this.amigoTextBox = new System.Windows.Forms.TextBox();
         this.agregarButton = new System.Windows.Forms.Button();
         this.contadorLabel = new System.Windows.Forms.Label();
         this.agregar5Button = new System.Windows.Forms.Button();
         this.btn_ordenAscendente = new System.Windows.Forms.Button();
         this.btn_ordenDescendente = new System.Windows.Forms.Button();
         this.btn_Limpiar = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // amigosListBox
         // 
         this.amigosListBox.FormattingEnabled = true;
         this.amigosListBox.Location = new System.Drawing.Point(12, 12);
         this.amigosListBox.Name = "amigosListBox";
         this.amigosListBox.Size = new System.Drawing.Size(275, 420);
         this.amigosListBox.TabIndex = 0;
         // 
         // amigoTextBox
         // 
         this.amigoTextBox.Location = new System.Drawing.Point(293, 12);
         this.amigoTextBox.Name = "amigoTextBox";
         this.amigoTextBox.Size = new System.Drawing.Size(243, 20);
         this.amigoTextBox.TabIndex = 1;
         // 
         // agregarButton
         // 
         this.agregarButton.Location = new System.Drawing.Point(293, 38);
         this.agregarButton.Name = "agregarButton";
         this.agregarButton.Size = new System.Drawing.Size(75, 23);
         this.agregarButton.TabIndex = 2;
         this.agregarButton.Text = "Agregar";
         this.agregarButton.UseVisualStyleBackColor = true;
         this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
         // 
         // contadorLabel
         // 
         this.contadorLabel.AutoSize = true;
         this.contadorLabel.Location = new System.Drawing.Point(374, 43);
         this.contadorLabel.Name = "contadorLabel";
         this.contadorLabel.Size = new System.Drawing.Size(35, 13);
         this.contadorLabel.TabIndex = 3;
         this.contadorLabel.Text = "label1";
         // 
         // agregar5Button
         // 
         this.agregar5Button.Location = new System.Drawing.Point(293, 67);
         this.agregar5Button.Name = "agregar5Button";
         this.agregar5Button.Size = new System.Drawing.Size(75, 23);
         this.agregar5Button.TabIndex = 4;
         this.agregar5Button.Text = "Agregar 5";
         this.agregar5Button.UseVisualStyleBackColor = true;
         this.agregar5Button.Click += new System.EventHandler(this.agregar5Button_Click);
         // 
         // btn_ordenAscendente
         // 
         this.btn_ordenAscendente.Location = new System.Drawing.Point(293, 409);
         this.btn_ordenAscendente.Name = "btn_ordenAscendente";
         this.btn_ordenAscendente.Size = new System.Drawing.Size(75, 23);
         this.btn_ordenAscendente.TabIndex = 5;
         this.btn_ordenAscendente.Text = "A -> Z";
         this.btn_ordenAscendente.UseVisualStyleBackColor = true;
         this.btn_ordenAscendente.Click += new System.EventHandler(this.btn_ordenAscendente_Click);
         // 
         // btn_ordenDescendente
         // 
         this.btn_ordenDescendente.Location = new System.Drawing.Point(374, 409);
         this.btn_ordenDescendente.Name = "btn_ordenDescendente";
         this.btn_ordenDescendente.Size = new System.Drawing.Size(75, 23);
         this.btn_ordenDescendente.TabIndex = 6;
         this.btn_ordenDescendente.Text = "Z -> A";
         this.btn_ordenDescendente.UseVisualStyleBackColor = true;
         this.btn_ordenDescendente.Click += new System.EventHandler(this.btn_ordenDescendente_Click);
         // 
         // btn_Limpiar
         // 
         this.btn_Limpiar.Location = new System.Drawing.Point(455, 409);
         this.btn_Limpiar.Name = "btn_Limpiar";
         this.btn_Limpiar.Size = new System.Drawing.Size(75, 23);
         this.btn_Limpiar.TabIndex = 7;
         this.btn_Limpiar.Text = "Limpiar";
         this.btn_Limpiar.UseVisualStyleBackColor = true;
         this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
         // 
         // MisAmigos
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(548, 445);
         this.Controls.Add(this.btn_Limpiar);
         this.Controls.Add(this.btn_ordenDescendente);
         this.Controls.Add(this.btn_ordenAscendente);
         this.Controls.Add(this.agregar5Button);
         this.Controls.Add(this.contadorLabel);
         this.Controls.Add(this.agregarButton);
         this.Controls.Add(this.amigoTextBox);
         this.Controls.Add(this.amigosListBox);
         this.Name = "MisAmigos";
         this.Text = "Lista de amigos";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ListBox amigosListBox;
      private System.Windows.Forms.TextBox amigoTextBox;
      private System.Windows.Forms.Button agregarButton;
      private System.Windows.Forms.Label contadorLabel;
      private System.Windows.Forms.Button agregar5Button;
      private System.Windows.Forms.Button btn_ordenAscendente;
      private System.Windows.Forms.Button btn_ordenDescendente;
      private System.Windows.Forms.Button btn_Limpiar;
   }
}


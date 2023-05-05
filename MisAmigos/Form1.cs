using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisAmigos
{
   public partial class MisAmigos : Form
   {
      List<string> misAmigos = new List<string>();
      BindingSource bs = new BindingSource();
      
      public MisAmigos()
      {
         InitializeComponent();
         bs.DataSource = misAmigos;
         contadorLabel.Text = "Hay 0 personas en la lista.";
      }

      private void agregarButton_Click(object sender, EventArgs e)
      {
         misAmigos.Add(amigoTextBox.Text);
         amigosListBox.DataSource = bs;
         bs.ResetBindings(false);
         contadorLabel.Text = "Hay " + misAmigos.Count + " personas en la lista.";
      }

      private void agregar5Button_Click(object sender, EventArgs e)
      {
         misAmigos.Add("Pedro");
         misAmigos.Add("Jorge");
         misAmigos.Add("Ricardo");
         misAmigos.Add("Goku");
         misAmigos.Add("Naruto");
         amigosListBox.DataSource = bs;
         bs.ResetBindings(false);
         contadorLabel.Text = "Hay " + misAmigos.Count + " personas en la lista.";
      }

      private void btn_ordenAscendente_Click(object sender, EventArgs e)
      {
         misAmigos.Sort();
         bs.ResetBindings(false);
      }

      private void btn_ordenDescendente_Click(object sender, EventArgs e)
      {
         misAmigos.Sort();
         misAmigos.Reverse();
         bs.ResetBindings(false);
      }

      private void btn_Limpiar_Click(object sender, EventArgs e)
      {
         misAmigos.Clear();
         bs.ResetBindings(false);
         contadorLabel.Text = "Hay " + misAmigos.Count + " personas en la lista.";
      }
   }
}

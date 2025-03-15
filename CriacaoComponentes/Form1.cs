using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriacaoComponentes
{   

    public partial class Form1 : Form
    {
        List<Produto> produtos = new List<Produto>();
        private bool rendered = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCriar_Click(object sender, EventArgs e)
        {
             if (!rendered)
            {
                this.Render();
            }
            else
            {
                MessageBox.Show("Já Está Criado");
            }


        }

        private void Render()
        {
            Label lblQuant = new Label();

            lblQuant.Name = "lblQuant";
            lblQuant.Text = "Quantidade";
            lblQuant.Location = new Point(57, 131);
            lblQuant.Width = 65;
            this.Controls.Add(lblQuant);

            Label lblDesc = new Label()
            {
                Name = "lblDesc",
                Text = "Descrição: ",
                Location = new Point(53, 181),
                Width = 65
            };
            this.Controls.Add(lblDesc);

            TextBox txtQuant = new TextBox()
            {
                Name = "txtQuant",
                Location = new Point(129, 131),

            };
            this.Controls.Add(txtQuant);

            TextBox txtDesc = new TextBox()
            {
                Name = "txtDesc",
                Location = new Point(129, 181),

            };
            this.Controls.Add(txtDesc);
            Button btnSave = new Button()
            {
                Name = "btnSave",
                Text = "Salvar",
                Location = new Point(248, 131),
                Size = new Size(75, 67)
            };
            btnSave.Click += (s, e) =>
            {
                String name = txtNome.Text;
                double price = double.Parse(txtPreco.Text);
                int quant = int.Parse(txtQuant.Text);
                string desc = txtDesc.Text;
                Produto produto = new Produto(name, price, desc, quant);
                produtos.Add(produto);
                DataTable tabela = new DataTable();
                

                tabela.Columns.Add("Nome: ", typeof(string));
                tabela.Columns.Add("Preço", typeof(Double));
                tabela.Columns.Add("Descrição", typeof(string));
                tabela.Columns.Add("Quantidade", typeof(int));
                produtos.ForEach(produtos => tabela.Rows.Add(name,price,desc,quant));

                dataGridView1.DataSource = tabela;
                MessageBox.Show("Criado Com Sucesso!");
                this.rendered = false;


            };
            
            this.Controls.Add(btnSave);
            this.rendered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

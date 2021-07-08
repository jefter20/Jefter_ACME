using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jefter_ACME.Dominio;
using Jefter_AMCE.Negocios;

namespace Jefter_AMCE.Visualizacao
{
    public partial class FormVoo : Form
    {
        VooDominio objVoo = new VooDominio();

        public FormVoo()
        {
            InitializeComponent();
        }

        private string opcoes = "";
        private string captura = "";

        private void IniciarOpcoes()
        {
            switch (opcoes)
            {
                case "Salvar":
                    try
                    {
                        if (txtData.Text == "" | txtCusto.Text == "" | txtDistancia.Text == "" | txtNivelDor.Text == "" | rbtnCapturaNao.Checked == false & rbtnCapturaSim.Checked == false)
                        {
                            MessageBox.Show("Por favor, preencha todos os campos!");
                            txtData.Focus();
                            return;
                        }

                        objVoo.Data_voo = DateTime.Parse(txtData.Text);
                        objVoo.Custo = double.Parse(txtCusto.Text);
                        objVoo.Distancia = int.Parse(txtDistancia.Text);
                        if (rbtnCapturaNao.Checked)
                        {
                            objVoo.Captura = "N";
                        }

                        if (rbtnCapturaSim.Checked)
                        {
                            objVoo.Captura = "S";
                        }
                        objVoo.Nivel_dor = int.Parse(txtNivelDor.Text);


                        int x = VooNegocios.Salvar(objVoo);

                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("Voo finalizado!"));

                            FormConfiguracaoPadrao();
                        }
                        else
                        {
                            MessageBox.Show("Voo mal sucedido!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao salvar " + ex.Message);

                    }
                    break;

                case "Atualizar":
                    try
                    {
                        if (txtData.Text == "" | txtCusto.Text == "" | txtDistancia.Text == "" | txtNivelDor.Text == "" | rbtnCapturaNao.Checked == false & rbtnCapturaSim.Checked == false)
                        {
                            MessageBox.Show("Por favor, preencha todos os campos!");
                            txtData.Focus();
                            return;
                        }

                        objVoo.Id_voo = Convert.ToInt32(txtId.Text);
                        objVoo.Data_voo = Convert.ToDateTime(txtData.Text);
                        objVoo.Custo = Convert.ToDouble(txtCusto.Text);
                        objVoo.Distancia = Convert.ToInt32(txtDistancia.Text);
                        if (rbtnCapturaNao.Checked)
                        {
                            objVoo.Captura = "N";
                        }

                        if (rbtnCapturaSim.Checked)
                        {
                            objVoo.Captura = "S";
                        }
                        objVoo.Nivel_dor = Convert.ToInt32(txtNivelDor.Text);

                        int x = VooNegocios.Atualizar(objVoo);

                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("Voo {0} alterado com sucesso!", txtId.Text));

                            FormConfiguracaoPadrao();
                        }
                        else
                        {
                            MessageBox.Show("Voo não alterado!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro e a alteração do registro de voo não foi finalizada" + ex.Message);

                    }
                    break;

                case "Excluir":
                    try
                    {
                        objVoo.Id_voo = Convert.ToInt32(txtId.Text);

                        int x = VooNegocios.Excluir(objVoo);

                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("Voo {0} excluido com sucesso!", txtId.Text));

                            FormConfiguracaoPadrao();

                        }
                        else
                        {
                            MessageBox.Show("Voo não excluido");
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Erro ao excluir voo " + ex.Message);
                    }
                    break;
            }
        }

        public void ListarGrid()
        {
            try
            {
                List<VooDominio> lista = new List<VooDominio>();
                lista = new VooNegocios().Lista();
                GridVoo.AutoGenerateColumns = false;
                GridVoo.DataSource = lista;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao listar Dados" + ex.Message);
            }
        }

        private void GridVoo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = GridVoo.CurrentRow.Cells[0].Value.ToString();
            txtData.Text = GridVoo.CurrentRow.Cells[1].Value.ToString();
            txtCusto.Text = GridVoo.CurrentRow.Cells[2].Value.ToString();
            txtDistancia.Text = GridVoo.CurrentRow.Cells[3].Value.ToString();
            captura = GridVoo.CurrentRow.Cells[4].Value.ToString();
            if (captura == "S")
            {
                rbtnCapturaSim.Checked = true;
            }
            else
            {
                rbtnCapturaNao.Checked = true;
            }
            txtNivelDor.Text = GridVoo.CurrentRow.Cells[5].Value.ToString();


            HabilitarCampos();

            btnIncluir.Enabled = false;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void FormConfiguracaoPadrao()
        {
            LimparCampos();
            DesabilitarCampos();
            ListarGrid();
            btnIncluir.Enabled = true;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void LimparCampos()
        {
            txtId.Text = "";
            txtData.Text = "";
            txtCusto.Text = "";
            txtDistancia.Text = "";
            rbtnCapturaNao.Checked = false;
            rbtnCapturaSim.Checked = false;
            txtNivelDor.Text = "";
        }

        private void DesabilitarCampos()
        {
            txtData.Enabled = false;
            txtCusto.Enabled = false;
            txtDistancia.Enabled = false;
            rbtnCapturaNao.Enabled = false;
            rbtnCapturaSim.Enabled = false;
            txtNivelDor.Enabled = false;
        }

        private void HabilitarCampos()
        {
            txtData.Enabled = true;
            txtCusto.Enabled = true;
            txtDistancia.Enabled = true;
            rbtnCapturaNao.Enabled = true;
            rbtnCapturaSim.Enabled = true;
            txtNivelDor.Enabled = true;
            txtData.Focus();
        }

        private void SalvarCancelar()
        {
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = false;
        }

        private void ApenasCaracteresNumericos(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void FormVoo_Load(object sender, EventArgs e)
        {
            FormConfiguracaoPadrao();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCampos();
            btnIncluir.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtId.Text == "")
                        {
                opcoes = "Salvar";
                IniciarOpcoes();
            }else
            {
                opcoes = "Atualizar";
                IniciarOpcoes();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            opcoes = "Excluir";
            IniciarOpcoes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            DesabilitarCampos();
            ListarGrid();
            btnIncluir.Enabled = true;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void txtData_ValueChanged(object sender, EventArgs e)
        {
            SalvarCancelar();
        }

        private void txtCusto_TextChanged(object sender, EventArgs e)
        {
            SalvarCancelar();
        }

        private void txtDistancia_TextChanged(object sender, EventArgs e)
        {
            SalvarCancelar();
        }

        private void txtNivelDor_TextChanged(object sender, EventArgs e)
        {
            SalvarCancelar();

        }

        private void rbtnCapturaSim_CheckedChanged(object sender, EventArgs e)
        {
            SalvarCancelar();
        }

        private void rbtnCapturaNao_CheckedChanged(object sender, EventArgs e)
        {
            SalvarCancelar();
        }

        private void txtCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasCaracteresNumericos(e);
        }

        private void txtDistancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasCaracteresNumericos(e);

        }

        private void txtNivelDor_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasCaracteresNumericos(e);

        }
    }
}

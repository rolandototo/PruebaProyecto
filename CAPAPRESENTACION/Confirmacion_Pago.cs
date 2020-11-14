using CAPAENTIDADES;
using CAPANEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPAPRESENTACION
{
    public partial class Confirmacion_Pago : FormInvocadoBase
    {
        public Confirmacion_Pago()
        {
            InitializeComponent();
        }
        public static String IDPAGO;
        public static String MONTO;
        public static string FECHAVENCIMIENTO;
        private static bool LuhnAlgorithem(string input)
        {
            //convirtiendo la el numero a un array
            int[] CARD = new int[input.Length];
            for(int i=0;i<input.Length;i++)
            {
                CARD[i] = (int)(input[i] - '0');
            }
            //empezando desde la derecha,doblando cada digito, si es mayor a 9,mod 10 and +1 to remainder
            for(int i = CARD.Length - 2; i >= 0;i = i-2)
            {
                int tempValue = CARD[i];
                tempValue = tempValue * 2;
                if(tempValue > 9)
                {
                    tempValue = tempValue % 10 + 1;
                }
                CARD[i] = tempValue;
            }
            //agregando los digitos
            int total = 0;
            for(int i =0;i<CARD.Length;i++)
            {
                total += CARD[i];
            }
            //si el numero es multiple de 10, es valido
            if(total % 10 == 0)
            {
                return true;
            }
            return false;
        }
        private static bool CVV(string input)
        {
            MatchCollection matches = Regex.Matches(input, @"^[\d]{3,3}$");
            if (matches.Count > 0)
            {
                return true;
            }
            return false;
        }
        N_Alumno neg = new N_Alumno();
        E_PAGO entities = new E_PAGO();
        private void BTNPAGAR_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (LuhnAlgorithem(TXTNUMEROTargeta.Text) == true && CVV(TXTCVV.Text) == true)
                {
                    string HOY = DateTime.Now.ToString("yyyy-MM-dd");
                    string TODAY = DateTime.Now.ToString("dd/MM/yyyy");
                    DateTime date = Convert.ToDateTime(TODAY);
                    DateTime FECHAVEN = Convert.ToDateTime(FECHAVENCIMIENTO);
                    int RESULT = DateTime.Compare(date,FECHAVEN);

                    if (RESULT < 0)
                    {
                        FormInformacion frm = new FormInformacion("ESTA SEGURO DE REALIZAR EL PAGO ?", "EL SE LE DESCONTARAN DE SU TARGETA EL MONTO SELECCIONADO DESEA CONTINUAR ?");
                        DialogResult result = frm.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            //CODIGO PARA CANCELAR
                            entities.IDPago = Convert.ToInt32(IDPAGO);
                            entities.DetallePago = "CANCELADO";
                            entities.MetodoPago = "TARGETA CRE/DEB";
                            entities.FechaPago = Convert.ToDateTime(HOY);
                            entities.PagoStatus = 1;
                            neg.REALIZARPAGO(entities);
                            FormSucces.confirmacionForm("PAGO REALIZADO");
                            Factura FRM = new Factura();
                            Factura.IDPAGO = IDPAGO;
                            FRM.ShowDialog();
                            Close();
                            //CODIGO PARA CANCELAR
                        }
                    }
                    else if (RESULT == 0)
                    {
                        FormInformacion frm = new FormInformacion("ESTA SEGURO DE REALIZAR EL PAGO ?", "EL SE LE DESCONTARAN DE SU TARGETA EL MONTO SELECCIONADO DESEA CONTINUAR ?");
                        DialogResult result = frm.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            //CODIGO PARA CANCELAR
                            entities.IDPago = Convert.ToInt32(IDPAGO);
                            entities.DetallePago = "CANCELADO";
                            entities.MetodoPago = "TARGETA CRE/DEB";
                            entities.FechaPago = Convert.ToDateTime(HOY);
                            entities.PagoStatus = 1;
                            neg.REALIZARPAGO(entities);
                            FormSucces.confirmacionForm("PAGO REALIZADO");
                            Factura FRM = new Factura();
                            Factura.IDPAGO = IDPAGO;
                            FRM.ShowDialog();
                            Close();
                            //CODIGO PARA CANCELAR
                        }
                    }
                    else
                    {
                        //PARA COBRAR MORA
                        FormInformacion frm = new FormInformacion("ESTA SEGURO DE REALIZAR EL PAGO ?", "EL SISTEMA DETECTO QUE LA FECHA DE VENCIMIENTO YA EXPIRO ENTONCES SE LE COBRARA MORA DE $10.");
                        DialogResult result = frm.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            Decimal TOTAL = Convert.ToDecimal(MONTO) + 10;
                            //CODIGO PARA CANCELAR
                            entities.IDPago = Convert.ToInt32(IDPAGO);
                            entities.DetallePago = "CANCELADO";
                            entities.Monto = TOTAL;
                            entities.MetodoPago = "TARGETA CRE/DEB";
                            entities.FechaPago = Convert.ToDateTime(HOY);
                            entities.PagoStatus = 1;
                            neg.PAGOCONMORA(entities);
                            FormSucces.confirmacionForm("PAGO REALIZADO");
                            Factura FRM = new Factura();
                            Factura.IDPAGO = IDPAGO;
                            FRM.ShowDialog();
                            Close();
                            //CODIGO PARA CANCELAR
                        }
                    }

                }
                else
                {
                    FormWarning.confirmacionForm("ERROR", "NO SE PUDO COMPLETAR LA TRANSACCION, REVISE SI TODOS LOS CAMPOS ESTAN BIEN.");
                }
            }
            catch (Exception EX)
            {
                FormWarning.confirmacionForm("ERROR", EX.Message);
            }
        }

        private void BTNSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Confirmacion_Pago_Load(object sender, EventArgs e)
        {
            try
            {
                LBTOTAL.Text = "MOTO :" + MONTO;
            }
            catch(Exception EX)
            {
                FormWarning.confirmacionForm("ERROR", EX.Message);
            }
        }

        private void limpiarlabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TXTCVV.Text = string.Empty;
            TXTNUMEROTargeta.Text = string.Empty;
            maskedTextBox1.Clear();
        }
    }
}

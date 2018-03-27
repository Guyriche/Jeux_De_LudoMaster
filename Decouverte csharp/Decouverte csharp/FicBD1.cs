using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Decouverte_csharp
{
    public partial class EcranBD1 : Form
    {
        private string sChConn 
            = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = 'D:\Nouveau doc 2eme IS\Quadrimestre II\Program even th(Mr Alexandre)\BD1\perso.mdb'";

        public EcranBD1()
        {
            InitializeComponent();
        }

        private void btnCharger_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(sChConn);
            Conn.Open();
            OleDbCommand comm = new OleDbCommand();
            comm.Connection = Conn;
            comm.CommandText = "SELECT PRE , NOM FROM Client ORDER BY NOM";
            OleDbDataReader dr = comm.ExecuteReader();
            while (dr.Read())
                lbContenu.Items.Add(dr["PRE"].ToString() + " " + dr["NOM"]);
            dr.Close();
            Conn.Close();
        }

        private void btnConpter_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(sChConn);
            Conn.Open();
            OleDbCommand comm = new OleDbCommand();
            comm.Connection = Conn;
            comm.CommandText = "SELECT COUNT(NOM) FROM Client";
            int nb = (int)comm.ExecuteScalar();
            MessageBox.Show(nb.ToString() + " ebregistrements");
            Conn.Close();
        }

        private void btnSauver_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(sChConn);
            Conn.Open();
            OleDbCommand comm = new OleDbCommand();
            comm.Connection = Conn;
            comm.CommandText = "INSERT INTO Client (NOM , PRE) VALUES('" + tbNom.Text + "' , '" + tbPre.Text + "')";
            int nb = (int)comm.ExecuteNonQuery();
            MessageBox.Show(nb.ToString() + "enregistrement(s) effectué(s)");
            Conn.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(sChConn);
            Conn.Open();
            OleDbCommand comm = new OleDbCommand();
            comm.Connection = Conn;
            comm.CommandText = "DELETE FROM CLient WHERE NOM = '" + tbSup.Text + "'";
            int nb = (int)comm.ExecuteNonQuery();
            MessageBox.Show(nb.ToString() + "suppression(s) effectuée(s)");
            Conn.Close();
        }
    }
    
    
}

using SmartGrid;
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace SmartGridWebSite
{
    public partial class Default : System.Web.UI.Page
    {
        public List<string> errors = new List<string>();
        protected void Page_Load(object sender, System.EventArgs e)
        {
            if (IsPostBack)
            {
                this.ucSmartGrid.SetHandlers(
                delegate (string detailId)
                {
                    int convID;
                    int.TryParse(detailId, out convID);
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "provaPostBack",
                        "<script> $(function () { alert(\"Prova PostBack, Comando: Detail; ID: " + convID + "\"); });</script>");
                }, delegate (string editID)
                {
                    int convID;
                    int.TryParse(editID, out convID);
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "provaPostBack",
                        "<script> $(function () { alert(\"Prova PostBack, Comando: Edit; ID: " + convID + "\"); });</script>");
                }, delegate (string deleteID)
                {
                    int convID;
                    int.TryParse(deleteID, out convID);
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "provaPostBack",
                        "<script> $(function () { alert(\"Prova PostBack, Comando: Delete; ID: " + convID + "\"); });</script>");
                }, delegate (string listOfID)
                {
                    string[] iDs = listOfID.Split(',');
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "provaPostBack",
                        "<script> $(function () { alert(\"Prova PostBack, Comando: MultipleAction; ID-Count: " + iDs.Length + "\"); });</script>");
                });
            }

            this.ucSmartGrid.LoadSmartGrid<Oggetto>(getData(), true, true, new List<ucSmartGrid.ButtonTypeEnum>() { ucSmartGrid.ButtonTypeEnum.Excel, ucSmartGrid.ButtonTypeEnum.Pdf, ucSmartGrid.ButtonTypeEnum.Print },
                "Anagrafica");
        }
        [System.Web.Services.WebMethod(EnableSession = true)]
        public static ucSmartGrid.SmartGridData GetObjects()
        {
            return SmartGrid.ucSmartGrid.GetObjects();
        }

        private List<Oggetto> getData()
        {
            return new List<Oggetto>()
            {
                new Oggetto("Marco","Rossi","M",new DateTime (1992,1,23)){ID = 1},
                new Oggetto("Alessio","Bianchi","M",new DateTime (1991,2,2)){ID = 2},
                new Oggetto("Giulia","Monti","F",new DateTime (1978,6,11)){ID = 3},
                new Oggetto("Andrea","Altini","M",new DateTime (1965,7,27)){ID = 4},
                new Oggetto("Marco","Rossi","M",new DateTime (1992,1,23)){ID = 5},
                new Oggetto("Alessio","Bianchi","M",new DateTime (1991,2,2)){ID = 6},
                new Oggetto("Giulia","Monti","F",new DateTime (1978,6,11)){ID = 7},
                new Oggetto("Andrea","Altini","M",new DateTime (1965,7,27)){ID = 8},
                new Oggetto("Marco","Rossi","M",new DateTime (1992,1,23)){ID = 9},
                new Oggetto("Alessio","Bianchi","M",new DateTime (1991,2,2)){ID = 10},
                new Oggetto("Giulia","Monti","F",new DateTime (1978,6,11)){ID = 11},
                new Oggetto("Andrea","Altini","M",new DateTime (1965,7,27)){ID = 12},
                new Oggetto("Andrea","Altini","M",new DateTime (1965,7,27)){ID = 4},
                new Oggetto("Marco","Rossi","M",new DateTime (1992,1,23)){ID = 5},
                new Oggetto("Alessio","Bianchi","M",new DateTime (1991,2,2)){ID = 6},
                new Oggetto("Giulia","Monti","F",new DateTime (1978,6,11)){ID = 7},
                new Oggetto("Andrea","Altini","M",new DateTime (1965,7,27)){ID = 8},
                new Oggetto("Marco","Rossi","M",new DateTime (1992,1,23)){ID = 9},
                new Oggetto("Alessio","Bianchi","M",new DateTime (1991,2,2)){ID = 10},
                new Oggetto("Giulia","Monti","F",new DateTime (1978,6,11)){ID = 11},
                new Oggetto("Andrea","Altini","M",new DateTime (1965,7,27)){ID = 12},
                new Oggetto("Andrea","Altini","M",new DateTime (1965,7,27)){ID = 4},
                new Oggetto("Marco","Rossi","M",new DateTime (1992,1,23)){ID = 5},
                new Oggetto("Alessio","Bianchi","M",new DateTime (1991,2,2)){ID = 6},
                new Oggetto("Giulia","Monti","F",new DateTime (1978,6,11)){ID = 7},
                new Oggetto("Andrea","Altini","M",new DateTime (1965,7,27)){ID = 8},
                new Oggetto("Marco","Rossi","M",new DateTime (1992,1,23)){ID = 9},
                new Oggetto("Alessio","Bianchi","M",new DateTime (1991,2,2)){ID = 10},
                new Oggetto("Giulia","Monti","F",new DateTime (1978,6,11)){ID = 11},
                new Oggetto("Andrea","Altini","M",new DateTime (1965,7,27)){ID = 12},
                new Oggetto("Andrea","Altini","M",new DateTime (1965,7,27)){ID = 4},
                new Oggetto("Marco","Rossi","M",new DateTime (1992,1,23)){ID = 5},
                new Oggetto("Alessio","Bianchi","M",new DateTime (1991,2,2)){ID = 6},
                new Oggetto("Giulia","Monti","F",new DateTime (1978,6,11)){ID = 7},
                new Oggetto("Andrea","Altini","M",new DateTime (1965,7,27)){ID = 8},
                new Oggetto("Marco","Rossi","M",new DateTime (1992,1,23)){ID = 9},
                new Oggetto("Alessio","Bianchi","M",new DateTime (1991,2,2)){ID = 10},
                new Oggetto("Giulia","Monti","F",new DateTime (1978,6,11)){ID = 11},
                new Oggetto("Andrea","Altini","M",new DateTime (1965,7,27)){ID = 12},
                new Oggetto("Andrea","Altini","M",new DateTime (1965,7,27)){ID = 4},
                new Oggetto("Marco","Rossi","M",new DateTime (1992,1,23)){ID = 5},
                new Oggetto("Alessio","Bianchi","M",new DateTime (1991,2,2)){ID = 6},
                new Oggetto("Giulia","Monti","F",new DateTime (1978,6,11)){ID = 7},
                new Oggetto("Andrea","Altini","M",new DateTime (1965,7,27)){ID = 8},
                new Oggetto("Marco","Rossi","M",new DateTime (1992,1,23)){ID = 9},
                new Oggetto("Alessio","Bianchi","M",new DateTime (1991,2,2)){ID = 10},
                new Oggetto("Giulia","Monti","F",new DateTime (1978,6,11)){ID = 11},
                new Oggetto("Andrea","Altini","M",new DateTime (1965,7,27)){ID = 12},
            };
        }
    }
}

public class Oggetto
{
    [SmartGrid(new SmartGridAttribute.ColumnTypeEnum[] { SmartGridAttribute.ColumnTypeEnum.DetailColumn,
                SmartGridAttribute.ColumnTypeEnum.EditColumn ,
                SmartGridAttribute.ColumnTypeEnum.DeleteColumn ,
                SmartGridAttribute.ColumnTypeEnum.CheckBox }, "", "APRI")]
    public int ID { get; set; }
    [SmartGrid("Nome", 1)]
    public string NOME { get; set; }
    [SmartGrid("Cognome", 0)]
    public string COGNOME { get; set; }
    [SmartGrid("Sesso", new SmartGridAttribute.ColumnTypeEnum[] { SmartGridAttribute.ColumnTypeEnum.Select }, 2)]
    public string SESSO { get; set; }
    [SmartGrid("Data Nascita", new SmartGridAttribute.ColumnTypeEnum[] { SmartGridAttribute.ColumnTypeEnum.Date }, 1)]
    public DateTime DATANASCITA { get; set; }

    public Oggetto(string nome, string cognome, string sesso, DateTime dataNascita)
    {
        this.NOME = nome;
        this.COGNOME = cognome;
        this.SESSO = sesso;
        this.DATANASCITA = dataNascita;
    }
}
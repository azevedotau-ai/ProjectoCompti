using ClosedXML.Excel;
namespace ProjectoCompti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            FuncaoPrincipal();
        }

        #region
        // Função Responsavel pela Abertura da Caixa de Dialog, e Carregamento Do Arquivo
        #endregion
        private void FuncaoPrincipal()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Selecionar Ficheiro";
            openFileDialog1.InitialDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName.ToString(); //@"C:\Users\azevedo.tau\source\repos\ProjectoCompti\ProjectoCompti";//--"C:\\";
            openFileDialog1.Filter = "All files (*.*)|*.*|Text File (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.ShowDialog();

         


            if (openFileDialog1.FileName != "")
            {
                this.InputFileEntrada.Text = openFileDialog1.FileName;
                this.InputBig.Text = File.ReadAllText(openFileDialog1.FileName);
                List<String> Idlist = new List<String>();
                List<String> nomelist = new List<String>();
                List<String> anoList = new List<String>();
                List<String> Valorlist = new List<String>();

                var lines = File.ReadAllLines(openFileDialog1.FileName);
                for (var i = 0; i < lines.Length; i += 1)
                {
                    var line = lines[i];
                    var idClinte = line.Substring(0, 6);
                    var nomeCliente = line.Substring(idClinte.Length, 11);
                    var anoCliente = line.Substring(17, 8);
                    var valorCliente = line.Substring(25, 6);

                    Idlist.Add(idClinte);
                    nomelist.Add(nomeCliente);
                    anoList.Add(anoCliente);
                    Valorlist.Add(valorCliente);
                }
               
              
                EscreverFileExcel(Idlist, nomelist, anoList, Valorlist);
            }
            else
            {
                this.InputFileEntrada.Text = "Não Selecionou o Ficheiro";

            }
        }


        #region
        // Função Responsavel pelo Carregamento Dos Dados Para o Ficheiro Excel.
        #endregion
        private void EscreverFileExcel(List<string> codigos, List<string> nomes, List<string> anos, List<string> valores)
        {
            var caminhoSalvar = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName.ToString();

            using (var workbook = new XLWorkbook())
            {
                var workSheet = workbook.Worksheets.Add("Planilha1");

                workSheet.Cell(2,2).Value = "Código";
                workSheet.Cell(2,2).Style.Fill.BackgroundColor = XLColor.Green;
                workSheet.Cell(2,2).Style.Font.FontColor = XLColor.White;


                workSheet.Cell(2, 3).Value = "Nome";
                workSheet.Cell(2, 3).Style.Fill.BackgroundColor = XLColor.Yellow;
                workSheet.Cell(2, 3).Style.Font.FontColor = XLColor.Red;

                workSheet.Cell(2, 4).Value = "Data";
                workSheet.Cell(2, 4).Style.Fill.BackgroundColor = XLColor.RedPigment;
                workSheet.Cell(2, 4).Style.Font.FontColor = XLColor.White;

                workSheet.Cell(2, 5).Value = "Valor";
                workSheet.Cell(2, 5).Style.Fill.BackgroundColor = XLColor.Blue;
                workSheet.Cell(2, 5).Style.Font.FontColor = XLColor.White;

                var range = workSheet.Range("B3:B100");
                int index = 3;


                for (int i = 0; i < codigos.Count; i++)
                {
                    var codigo = codigos[i];
                    var nomeCliente = nomes[i];
                    var data = anos[i];
                    var valor = valores[i];


                    workSheet.Cell("B"+index).Value = codigo;
                    workSheet.Cell("C" + index).Value = nomeCliente;
                    workSheet.Cell("D" + index).Value = data;
                    workSheet.Cell("E" + index).Value = valor;

                    index++;
                }


                workbook.SaveAs(caminhoSalvar + @"\ficheiros\ComptiTeste.xlsx");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
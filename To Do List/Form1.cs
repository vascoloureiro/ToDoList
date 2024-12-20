using System.Configuration.Internal;
using System.Net;

namespace To_Do_List
{
    public partial class Form1 : Form
    {
        public static List<string> listaTarefas = new List<string>();
        public static string autoSaveCaminho = "D:/Portofolio Programa��o/To Do List/To Do List/LocalDataStore/data.txt";

        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Carregar dados do ficheiro no in�cio da aplica��o, se a lista estiver vazia
            if (checkedListBox.Items.Count == 0)
            {
                UploadFile(); // Carrega os dados do ficheiro automaticamente
            }
        }
        /* Atualiza a check box com um novo elemento*/
        public void UpdateCheckList()
        {
            if (listaTarefas.Count == 0 && checkedListBox.Items.Count == 0)
            {
                UploadFile();
            }
            else
            {
                checkedListBox.Items.Clear();
                foreach (string items in listaTarefas)
                {
                    checkedListBox.Items.Add(items);
                }
            }
        }

        /*Atualiza a checkBox Com o ultimo ficheiro txt ficheiro */
        public void TxtToCheckList(string items)
        {
            AddToList(items);
        }

        /*Adicona task a checklist*/
        public void AddToList(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                listaTarefas.Add(input);
                UpdateCheckList();
            }
            else
            {
                throw new Exception("Nulo");
            }


        }

        /* Remove tarefas realizadas da checklist*/
        public static void RemoveFromList(string remove)
        {
            listaTarefas.Remove(remove);

        }

        /*Para o o butao save*/
        public static void Save(List<string> listaTarefas)
        {
            try
            {
                string directory = Path.GetDirectoryName(autoSaveCaminho);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                using (StreamWriter sw = File.CreateText(autoSaveCaminho))
                {
                    foreach (string task in listaTarefas)
                    {
                        sw.WriteLine(task);
                    }
                    string caminhoCompleto = Path.GetFullPath(autoSaveCaminho);
                    MessageBox.Show($"O arquivo ser� salvo em: {caminhoCompleto}");
                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }

        /* Evia os dados para a ckeckList*/
        public void UploadFile()
        {
            try
            {
                if (File.Exists(autoSaveCaminho))
                {
                    using (StreamReader sr = File.OpenText(autoSaveCaminho))
                    {
                        string linha;
                        while ((linha = sr.ReadLine()) != null)
                        {
                            TxtToCheckList(linha);
                        }
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string inputTask = inputTextBox.Text;
            try
            {
                AddToList(inputTask);
                inputTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void input_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            try
            {
                
                if (checkedListBox.SelectedItems != null)
                {
                    string selectedTask = checkedListBox.SelectedItem.ToString();
                    RemoveFromList(selectedTask);
                    UpdateCheckList();
                }
                else if(checkedListBox.Items.Count == 0 && listaTarefas.Count < 0){
                    UploadFile();
                }
                else
                {
                    MessageBox.Show("Erro Desconhecido");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Save(listaTarefas);
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            if (checkedListBox.Items.Count > 0)
            {
                checkedListBox.Items.Clear();
            }
            UploadFile();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listaTarefas.Clear();
            
            checkedListBox.Items.Clear();
        }

 
    }
}

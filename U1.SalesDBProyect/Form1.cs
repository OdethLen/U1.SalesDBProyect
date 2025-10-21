using Microsoft.Data.SqlClient;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Infrastructure;
using System;
using System.Data;
using System.Diagnostics;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Linq;


namespace U1.SalesDBProyect
{
    public partial class Form1 : Form
    {
        string connectionString;

        public Form1()
        {
            InitializeComponent();
            connectionString = @"Server=localhost\SQLEXPRESS;Database=Sales;Trusted_Connection=True;TrustServerCertificate=True;";
            cbxName.Items.Add("ASC");
            cbxName.Items.Add("DESC");
            cbxName.SelectedIndex = -1; // No seleccionar por defecto


            cbxCountry.Items.Add("Afghanistan");
            cbxCountry.Items.Add("Bahamas");
            cbxCountry.Items.Add("Cuba");
            cbxCountry.SelectedIndex = -1; // No seleccionar por defecto

            cbxGender.Items.Add("Male");
            cbxGender.Items.Add("Female");
            cbxGender.Items.Add("Other");
            cbxGender.SelectedIndex = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Aquí puedes agregar acciones al hacer clic en las celdas si lo deseas
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    // Verificar si la conexión realmente se abrió
                    if (connection.State == ConnectionState.Open)
                    {
                        // Mostrar mensaje solo si la carga realmente va a iniciar
                        MessageBox.Show("Loading data... please wait");
                    }

                    // Consulta SQL: solo los primeros 100,000 registros
                    string query = "SELECT * FROM vw_Top100kCustomers";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    // Medir tiempo de carga
                    var start = DateTime.Now;
                    adapter.Fill(dataTable);
                    var end = DateTime.Now;

                    // Si realmente se cargó algo, mostrarlo
                    if (dataTable.Rows.Count > 0)
                    {
                        dgvData.DataSource = dataTable;
                        TimeSpan duration = end - start;
                        MessageBox.Show($"Data loaded successfully ({dataTable.Rows.Count} records) in {duration.TotalSeconds:F2} seconds.",
                                        "Load Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No records were loaded. The table may be empty.",
                                        "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.Text = "SalesDBProyect - Data Loaded";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while loading data: " + ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
        }

        private void LoadCustomerData(string order = "ASC")
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Limpiar DataGridView antes de recargar
                    dgvData.DataSource = null;

                    // Consulta SQL usando la vista y orden dinámico
                    string query = $"SELECT * FROM vw_Top100kCustomers ORDER BY [Name] {order}";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    var start = DateTime.Now;
                    adapter.Fill(dataTable);
                    var end = DateTime.Now;

                    if (dataTable.Rows.Count > 0)
                    {
                        dgvData.DataSource = dataTable;
                        TimeSpan duration = end - start;
                        MessageBox.Show($"Data loaded successfully ({dataTable.Rows.Count} records) in {duration.TotalSeconds:F2} seconds.",
                                        "Load Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No records were loaded. The table may be empty.",
                                        "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.Text = $"SalesDBProyect - Data Loaded ({order})";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while loading data: " + ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                        connection.Close();
                }
            }
        }


        private void btnFilterCountry_Click(object sender, EventArgs e)
        {
            if (cbxCountry.SelectedItem == null)
            {
                MessageBox.Show("Please select a country before applying the filter.",
                                "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedCountry = cbxCountry.SelectedItem.ToString();
            string viewName = "";

            switch (selectedCountry)
            {
                case "Afghanistan":
                    viewName = "vw_Top100kCustomers_Afghanistan";
                    break;
                case "Bahamas":
                    viewName = "vw_Top100kCustomers_Bahamas";
                    break;
                case "Cuba":
                    viewName = "vw_Top100kCustomers_Cuba";
                    break;
            }

            LoadCustomerDataByView(viewName);
        }

        private void btnFilterName_Click(object sender, EventArgs e)
        {
            if (cbxName.SelectedItem != null)
            {
                string order = cbxName.SelectedItem.ToString(); // ASC o DESC
                LoadCustomerData(order);
            }
            else
            {
                MessageBox.Show("Please select ASC or DESC before applying the filter.",
                                "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void LoadCustomerDataByView(string viewName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    dgvData.DataSource = null;

                    string query = $"SELECT * FROM {viewName}";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        dgvData.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show($"No records found for the selected country.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void cbxName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFilterGender_Click(object sender, EventArgs e)
        {
            if (cbxGender.SelectedItem == null)
            {
                MessageBox.Show("Please select a gender before applying the filter.",
                                "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedGender = cbxGender.SelectedItem.ToString();
            string viewName = "";

            switch (selectedGender)
            {
                case "Male":
                    viewName = "vw_Top100kCustomers_Male";
                    break;
                case "Female":
                    viewName = "vw_Top100kCustomers_Female";
                    break;
                case "Other":
                    viewName = "vw_Top100kCustomers_Other";
                    break;
            }

            // Llama al método que carga los datos según la vista seleccionada
            LoadCustomerDataByView(viewName);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Guardar como PDF";
                saveFileDialog.FileName = "export.pdf";

                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    return;

                string ruta = saveFileDialog.FileName;

                try
                {
                    // Obtener encabezados
                    var headers = dgvData.Columns.Cast<DataGridViewColumn>()
                                        .Select(c => c.HeaderText)
                                        .ToList();

                    // Obtener filas con formato correcto para fechas
                    var rows = new List<List<string>>();
                    foreach (DataGridViewRow row in dgvData.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            var cells = row.Cells.Cast<DataGridViewCell>()
                                .Select(cell =>
                                {
                                    if (cell.Value is DateTime dt)
                                        return dt.ToString("yyyy-MM-dd"); // Solo fecha
                                    else
                                        return cell.Value?.ToString() ?? "";
                                })
                                .ToList();
                            rows.Add(cells);
                        }
                    }

                    QuestPDF.Settings.License = LicenseType.Community;

                    // Crear documento
                    var document = Document.Create(container =>
                    {
                        container.Page(page =>
                        {
                            page.Margin(30);
                            page.Size(PageSizes.A4);
                            page.PageColor(Colors.White);
                            page.DefaultTextStyle(x => x.FontSize(9));

                            page.Content().Table(table =>
                            {
                                // Definir columnas
                                table.ColumnsDefinition(columns =>
                                {
                                    for (int i = 0; i < headers.Count; i++)
                                        columns.RelativeColumn();
                                });

                                // Encabezados
                                table.Header(header =>
                                {
                                    foreach (var headerText in headers)
                                    {
                                        header.Cell()
                                              .Background(Colors.Grey.Lighten2)
                                              .Padding(5)
                                              .Text(headerText)
                                              .SemiBold()
                                              .FontColor(Colors.Blue.Darken2);
                                    }
                                });

                                // Filas de datos
                                foreach (var row in rows)
                                {
                                    foreach (var cell in row)
                                    {
                                        table.Cell()
                                             .Padding(5)
                                             .Text(cell)
                                             .FontSize(8);
                                    }
                                }
                            });
                        });
                    });

                    document.GeneratePdf(ruta);

                    MessageBox.Show("PDF exportado correctamente.");

                    // Abrir el PDF generado
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = ruta,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exportando a PDF: " + ex.Message);
                }
            }
        }


        private void ExportXML(string ruta)
        {
            var root = new XElement("Registros");

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (!row.IsNewRow)
                {
                    var registro = new XElement("Registro");

                    foreach (DataGridViewColumn col in dgvData.Columns)
                    {
                        var valor = row.Cells[col.Index].Value;

                        // Formatear fechas para que no aparezca la hora
                        if (valor is DateTime dt)
                            valor = dt.ToString("yyyy-MM-dd");

                        registro.Add(new XElement(col.HeaderText, valor ?? ""));
                    }

                    root.Add(registro);
                }
            }

            var doc = new XDocument(root);
            doc.Save(ruta);
        }

        private void btnExportXML_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "XML files (*.xml)|*.xml";
                saveFileDialog.Title = "Guardar como XML";
                saveFileDialog.FileName = "export.xml";

                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    return;

                string ruta = saveFileDialog.FileName;

                try
                {
                    ExportXML(ruta);
                    MessageBox.Show("XML exportado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exportando a XML: " + ex.Message);
                }
            }
        }


        private void ExportJSON(string ruta)
        {
            var listaObjetos = new List<Dictionary<string, string>>();

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (!row.IsNewRow)
                {
                    var dict = new Dictionary<string, string>();
                    foreach (DataGridViewColumn col in dgvData.Columns)
                    {
                        var valor = row.Cells[col.Index].Value;

                        // Formatear fechas para que solo se guarde la fecha
                        if (valor is DateTime dt)
                            valor = dt.ToString("yyyy-MM-dd");

                        dict[col.HeaderText] = valor?.ToString() ?? "";
                    }
                    listaObjetos.Add(dict);
                }
            }

            var opciones = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(listaObjetos, opciones);

            File.WriteAllText(ruta, jsonString);
        }

        private void btnExportJson_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON files (*.json)|*.json";
                saveFileDialog.Title = "Guardar como JSON";
                saveFileDialog.FileName = "export.json";

                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    return;

                string ruta = saveFileDialog.FileName;

                try
                {
                    ExportJSON(ruta);
                    MessageBox.Show("JSON exportado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exportando a JSON: " + ex.Message);
                }
            }
        }
    }
}

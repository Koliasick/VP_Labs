
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace VP_3
{
    public partial class Form1 : Form
    {
        private int _currentItemIndex = -1;
        private List<CarInfo> carInfos;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            carInfos = Program.cars;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var car = new CarInfo();
            car.ComfortLevel = ComfortLevel.Any;
            car.FuelType = FuelType.Any;
            Program.cars.Add(car);
            if (Program.cars == carInfos)
            {
                listView1.Items.Add("New Car Info");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) 
            {
                _currentItemIndex = -1;
                Model.Text = string.Empty;
                CarName.Text = string.Empty;
                CarPrice.Value = 0;
                FuelConsumption.Text = string.Empty;
                radioButton4.Checked = true;
                Reliability.Value = 0;
                button6.Enabled = false;
                button2.Enabled = false;
                radioButton5.Checked = true;
                UnselectFilteringOptions();
                return;
            }
            button6.Enabled = true;
            button2.Enabled = true;
            int itemIndex = listView1.SelectedIndices[0];
            _currentItemIndex = itemIndex;
            var item = carInfos[itemIndex];
            Model.Text = item.Model;
            CarName.Text = item.Brand;
            CarPrice.Value = item.Price;
            FuelConsumption.Text = item.FuelConsumption.ToString();
            switch (item.FuelType) 
            {
                case FuelType.Benzine:
                    radioButton1.Checked = true;
                    break;
                case FuelType.Diesel:
                    radioButton2.Checked = true;
                    break;
                case FuelType.Electrycity:
                    radioButton3.Checked = true;
                    break;
                case FuelType.Any:
                    radioButton4.Checked = true;
                    break;
            }
            Reliability.Value = item.Reliability;
            switch (item.ComfortLevel) 
            {
                case ComfortLevel.Budget:
                    radioButton8.Checked = true;
                    break;
                case ComfortLevel.Comfortable:
                    radioButton7.Checked = true;
                    break;
                case ComfortLevel.Luxury:
                    radioButton6.Checked = true;
                    break;
                case ComfortLevel.Any:
                    radioButton5.Checked = true;
                    break;
            }
            UnselectFilteringOptions();
        }

        private void UnselectFilteringOptions() 
        {
            foreach (var radio in panel1.Controls.OfType<RadioButton>())
            {
                radio.Checked = false;
            }
            foreach (var radio in panel2.Controls.OfType<RadioButton>())
            {
                radio.Checked = false;
            }
            foreach (var radio in panel4.Controls.OfType<RadioButton>())
            {
                radio.Checked = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_currentItemIndex == -1)
            {
                return;
            }
            var elem = carInfos[_currentItemIndex];
            carInfos.RemoveAt(_currentItemIndex);
            if (carInfos != Program.cars) 
            {
                Program.cars.Remove(elem);
            }
            listView1.Items.RemoveAt(_currentItemIndex);
        }

        private void UpdateList() 
        {
            listView1.Items.Clear();

            foreach (var car in carInfos)
            {
                if (!string.IsNullOrEmpty(car.Model) &&
                    !string.IsNullOrWhiteSpace(car.Model))
                {
                    listView1.Items.Add(car.Model);
                }
                else
                {
                    listView1.Items.Add("New Car Info");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carInfos = Program.cars;
            UpdateList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML file|*.xml";
            saveFileDialog.Title = "Save Cars Data As XML File";
            saveFileDialog.FileName = "CarsInfo.xml";

            DialogResult result = saveFileDialog.ShowDialog();
            saveFileDialog.RestoreDirectory = true;

            if (result == DialogResult.OK && saveFileDialog.FileName != "")
            {
                try
                {
                    if (saveFileDialog.CheckPathExists)
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<CarInfo>));
                        TextWriter textWriter = new StreamWriter(saveFileDialog.FileName);
                        serializer.Serialize(textWriter, Program.cars);
                        textWriter.Close();
                    }
                    else
                    {
                        MessageBox.Show("Given Path does not exist");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XmlSchemaSet schema = new XmlSchemaSet();
            schema.Add("", "CarsInfo.xsd");

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML file|*.xml";
            openFileDialog.Title = "Open Cars Info";
            openFileDialog.FileName = "CarsInfo.xml";

            DialogResult result = openFileDialog.ShowDialog();
            openFileDialog.RestoreDirectory = true;

            if (result == DialogResult.OK && openFileDialog.FileName != "")
            {
                try
                {
                    if (openFileDialog.CheckPathExists)
                    {
                        XmlReader reader = XmlReader.Create(openFileDialog.FileName);
                        XDocument doc = XDocument.Load(reader);
                        doc.Validate(schema, ValidateHandler);

                        var serializationReader = doc.Root.CreateReader();
                        XmlSerializer serializer = new XmlSerializer(typeof(List<CarInfo>));
                        Program.cars = serializer.Deserialize(serializationReader) as List<CarInfo>;
                        serializationReader.Close();
                        reader.Close();
                        carInfos = Program.cars;
                        UpdateList();
                    }
                    else
                    {
                        MessageBox.Show("Given Path does not exist");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBox3_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!float.TryParse(FuelConsumption.Text, out _) && FuelConsumption.Text.Length > 0)
            {
                errorProvider1.SetError(FuelConsumption, "Enter positive real number");
                e.Cancel = true;
            }
            else 
            {
                errorProvider1.SetError(FuelConsumption, string.Empty);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_currentItemIndex == -1) 
            {
                return;
            }
            var item = carInfos[_currentItemIndex];
            item.Model = Model.Text;
            item.Brand = CarName.Text;
            item.Price = (int)CarPrice.Value;
            item.FuelType = GetSelectedFuelType();
            item.ComfortLevel = GetSelectedComfortLevel();
            item.Reliability = (int)Reliability.Value;
            item.FuelConsumption = float.Parse(FuelConsumption.Text);

            listView1.Items[_currentItemIndex].Text = Model.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var checkedButton1 = panel1.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            var checkedButton2 = panel2.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            var checkedButton4 = panel4.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            
            if ((checkedButton1 == default && CarPrice.Value > 0) ||
                (checkedButton2 == default && !string.IsNullOrEmpty(FuelConsumption.Text)) ||
                (checkedButton4 == default && Reliability.Value > 0)) 
            {
                MessageBox.Show("Select filtering options to apply filters");
                return;
            }

            FuelType fuelType = GetSelectedFuelType();

            ComfortLevel comfortLevel = GetSelectedComfortLevel();

            var partlyFilteredData =
                from car in Program.cars
                where car.Model.Contains(Model.Text) &&
                    car.Brand.Contains(CarName.Text) &&
                    (int)(car.FuelType & fuelType) > 0 &&
                    (int)(car.ComfortLevel & comfortLevel) > 0
                select car;

            IEnumerable<CarInfo>? filteredByPriceData;

            if (checkedButton1 == radioButton9)
            {
                filteredByPriceData =
                    from car in partlyFilteredData
                    where (CarPrice.Value == 0) || car.Price > CarPrice.Value
                    select car;
            }
            else if (checkedButton1 == radioButton10)
            {
                filteredByPriceData =
                    from car in partlyFilteredData
                    where (CarPrice.Value == 0) || car.Price < CarPrice.Value
                    select car;
            }
            else 
            {
                filteredByPriceData =
                    from car in partlyFilteredData
                    where (CarPrice.Value == 0) || car.Price == CarPrice.Value
                    select car;
            }

            IEnumerable<CarInfo>? filteredByFuelConsumption;

            if (checkedButton2 == radioButton13)
            {
                filteredByFuelConsumption =
                    from car in filteredByPriceData
                    where string.IsNullOrEmpty(FuelConsumption.Text) ||
                    car.FuelConsumption > float.Parse(FuelConsumption.Text)
                    select car;
            }
            else 
            {
                filteredByFuelConsumption =
                    from car in filteredByPriceData
                    where string.IsNullOrEmpty(FuelConsumption.Text) ||
                    car.FuelConsumption < float.Parse(FuelConsumption.Text)
                    select car;
            }

            IEnumerable<CarInfo>? finalResult;

            if (checkedButton4 == radioButton16)
            {
                finalResult =
                    from car in filteredByFuelConsumption
                    where Reliability.Value == 0 || car.Reliability > Reliability.Value
                    select car;
            }
            else if (checkedButton4 == radioButton15)
            {
                finalResult =
                    from car in filteredByFuelConsumption
                    where Reliability.Value == 0 || car.Reliability < Reliability.Value
                    select car;
            }
            else 
            {
                finalResult =
                    from car in filteredByFuelConsumption
                    where Reliability.Value == 0 || car.Reliability == Reliability.Value
                    select car;
            }

            carInfos = new List<CarInfo>(finalResult);

            UpdateList();
        }

        private FuelType GetSelectedFuelType() 
        {
            var checkedFuelButton = panel3.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            if (checkedFuelButton == radioButton1)
            {
                return FuelType.Benzine;
            }
            if (checkedFuelButton == radioButton2)
            {
                return FuelType.Diesel;
            }
            if (checkedFuelButton == radioButton3)
            {
                return FuelType.Electrycity;
            }
            else
            {
                return FuelType.Any;
            }
        }

        private ComfortLevel GetSelectedComfortLevel() 
        {
            var checkedComfortButton = panel5.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            if (checkedComfortButton == radioButton8)
            {
                return ComfortLevel.Budget;
            }
            if (checkedComfortButton == radioButton7)
            {
                return ComfortLevel.Comfortable;
            }
            if (checkedComfortButton == radioButton6)
            {
                return ComfortLevel.Luxury;
            }
            else
            {
                return ComfortLevel.Any;
            }
        }

        public void ValidateHandler(object? sender, ValidationEventArgs args) 
        {
            XmlSeverityType type = XmlSeverityType.Warning;
            if (Enum.TryParse<XmlSeverityType>("Error", out type))
            {
                if (type == XmlSeverityType.Error) throw new Exception(args.Message);
            }
        }
    }
}
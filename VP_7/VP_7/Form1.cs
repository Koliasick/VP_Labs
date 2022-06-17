namespace VP_7
{
    public partial class Form1 : Form
    {
        public Dictionary<int, string>? tapes;
        public Dictionary<int, string>? authors = new Dictionary<int, string>();
        private Dictionary<int, string>? _filteredAuthors;

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            var allTapes = Program.GetTapeNames();
            var filteredTapes =
                from keyVal in allTapes
                where keyVal.Value.Contains(comboBox1.Text)
                select keyVal;
            tapes = new Dictionary<int, string>(filteredTapes);
            UpdateListOne();
        }

        private void UpdateListOne() 
        {
            comboBox1.Items.Clear();
            foreach (var KVPair in tapes) 
            {
                comboBox1.Items.Add(KVPair.Value);
            }
            comboBox1.SelectionStart = comboBox1.Text.Length;
        }

        private void UpdateListTwo() 
        {
            comboBox2.Items.Clear();
            foreach (var KVPair in _filteredAuthors)
            {
                comboBox2.Items.Add(KVPair.Value);
            }
            comboBox2.SelectionStart = comboBox1.Text.Length;
        }

        private void DisplayTapeInfo(VideoTape tape) 
        {
            TapeName.Text = tape.Name;
            RecordType.Text = tape.RecordType;
            RTFText.Text = tape.RTFText;
            RecievementDate.Text = tape.RecievementDate.ToString();
            CreationDate.Text = tape.RecordDate.ToString();
            Length.Text = tape.RecordLength.ToString();
            TapeId.Text = tape.Id.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListOne();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list = new List<KeyValuePair<int, string>>(tapes.AsEnumerable());
            int id = list[comboBox1.SelectedIndex].Key;
            var tape = Program.GetTape(id);
            authors = new Dictionary<int, string>(tape.Authors.Select(author => new KeyValuePair<int, string>(author.Id, author.Name)));
            _filteredAuthors = authors;
            UpdateListTwo();
            DisplayTapeInfo(tape);
        }

        private void comboBox2_TextUpdate(object sender, EventArgs e)
        {
            var filteredAuthors =
                from keyVal in authors
                where keyVal.Value.Contains(comboBox2.Text)
                select keyVal;
            _filteredAuthors = new Dictionary<int, string>(filteredAuthors);
            UpdateListTwo();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list = new List<KeyValuePair<int, string>>(_filteredAuthors.AsEnumerable());
            int id = list[comboBox2.SelectedIndex].Key;
            var author = Program.GetAuthor(id);
            DisplayAuthorAndStudioInfo(author);
        }

        private void DisplayAuthorAndStudioInfo(Author author) 
        {
            AuthorName.Text = author.Name;
            Image image;
            using (var memStream = new MemoryStream(author.Photo.Data)) 
            {
                image = Image.FromStream(memStream);
            }
            AuthorPhoto.Image = image;
            Adress.Text = author.Address;
            Studio.Text = author.Agency.Name;
            StudioAddress.Text = author.Agency.Address;
            Director.Text = author.Agency.DirectorName;
            PhoneNumber.Text = author.Agency.PhoneNumber;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form editDataForm = new EditDataForm();
            editDataForm.ShowDialog();
        }
    }
}
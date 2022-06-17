using Microsoft.EntityFrameworkCore;

namespace VP_7
{
    internal static class Program
    {
        private static VideoStoreContext _context;

        static Program() 
        {
            _context = new VideoStoreContext();
        }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var form = new Form1();
            form.tapes = GetTapeNames();
            Application.Run(form);
        }

        public static Dictionary<int, string> GetTapeNames() 
        {
            var tapes = _context.Tapes
                .Select((tape) => new KeyValuePair<int, string>(tape.Id, tape.Name));
            return new Dictionary<int, string>(tapes);
        }

        public static VideoTape GetTape(int id) 
        {
            var result = _context.Tapes.Include(tape => tape.Authors).FirstOrDefault(tape => tape.Id == id);
            if (result == null) 
            {
                throw new Exception();
            }
            return result;
        }

        public static Author GetAuthor(int id) 
        {
            var result = _context.Authors.Include(author => author.Agency).Include(author => author.Photo).FirstOrDefault(author => author.Id == id);
            if (result == null)
            {
                throw new Exception();
            }
            return result;
        }

        public static List<VideoTape> GetTapes() 
        {
            return _context.Tapes.ToList();
        }

        public static List<Author> GetAuthors()
        {
            return _context.Authors.ToList();
        }

        public static List<Agency> GetAgencies()
        {
            return _context.Agencies.ToList();
        }

        public static void SaveChanges() 
        {
            _context.SaveChanges();
        }

        public static void AddTape(VideoTape tape) 
        {
            _context.Tapes.Add(tape);
        }

        public static void AddAgency(Agency agency)
        {
            _context.Agencies.Add(agency);
        }

        public static void AddAuthor(Author author)
        {
            _context.Authors.Add(author);
        }

        public static void Delete(object entry) 
        {
            _context.Remove(entry);
        }
    }
}
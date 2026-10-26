using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableLibrary.Models
{
    public class BookGenre : IModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public BookGenre()
        {

        }

        public BookGenre(int id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
        }

        public List<IModel> GenerateData()
        {
            return new List<IModel> { new BookGenre(1, "Фэнтези", "#fcba03"),
                                      new BookGenre(2, "Зарубежная литература", "#fcfc03"),
                                      new BookGenre(3, "Мистика", "#a9fc03"),
                                      new BookGenre(4, "Русская классика", "#03fc35"),
                                      new BookGenre(5, "Современная литература", "#03fcd7"),
                                      new BookGenre(6, "Школьная программа", "#0398fc"),
                                      new BookGenre(7, "Волшебство", "#9403fc"),
                                      new BookGenre(8, "Детектив", "#fc03d7"),
                                      new BookGenre(9, "Любовь", "#fc033d")};
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VariableLibrary.Models
{
    public class Author : IModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public Author()
        {

        }

        public Author(int id, string fullName)
        {
            Id = id;
            FullName = fullName;
        }

        public List<IModel> GenerateData()
        {
            return new List<IModel> { new Author(1, "Михаил Булгаков А."),
                                      new Author(2, "Стивен Кинг"),
                                      new Author(3, "Фёдор Достоевский М."),
                                      new Author(4, "Джоан Роулинг"),
                                      new Author(5, "Агата Кристи"),
                                      new Author(6, "Лев Толстой Н."),
                                      new Author(7, "Александр Пушкин С."),
                                      new Author(8, "Артур Конан Дойл"),
                                      new Author(9, "Джон Р.Р. Толкин"),  };
        }
    }
}

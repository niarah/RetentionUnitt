using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetentionUnit.Models
{
    public class QuestionModel
    {
        public List<Answer> Answers { get; set; }
        public string QuestionText { get; set; }

        public QuestionModel()
        {
            Answers = new List<Answer>();
        }
    }
}

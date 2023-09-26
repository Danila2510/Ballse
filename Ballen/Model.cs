using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Ballse
{
    internal class Model : IModel
    {
        public string Result { get; set; }
        public void Show()
        {

            List<string> answers = new List<string> { "Это несомненно", "Решительно так ", "Без сомнения",
                 "Да — однозначно", "На это можно положиться", "На мой взгляд, да", "Скорее всего" , "Прогноз хороший",
                 "Знаки указывают на да", "Да", "Ответ туманен", "попробуйте еще раз", "Спросите еще раз позже", "Лучше не говорить сейчас",
                 "Сейчас не могу предсказать", "Сконцентрируйтесь и спросите еще раз", "Не рассчитывайте на это", "Мой ответ — нет", "Мои источники говорят нет",
                 "Перспективы не очень хорошие", "Очень сомнительно"};
            Random random = new Random();
            Result = answers[random.Next(answers.Count)];
        }
    }
}

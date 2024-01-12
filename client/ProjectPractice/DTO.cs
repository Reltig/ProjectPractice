using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProjectPractice
{
    public class DTO
    {
        public string name { get; set; }
        public int accuracy { get; set; }
        public int density { get; set; }
        public int mode { get; set; }

        public override string ToString()
        {
            return $"{name}\n\nТочность - {accuracy}%\n\nРекомендованная плотность посадки - {density} шт/см^2\n\nРекомендованный режим полива - {mode} р/нед";
        }

        public string ToHistoryString()
        {
            return $"Название - {name} Точность - {accuracy}%";
        }
    }
}

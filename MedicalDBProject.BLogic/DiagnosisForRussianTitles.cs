﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalDBProject.BLogic
{
    //// Класс создан для промежуточного хранения данных, которые далее выводятся в DataGridView;
    //// Нужен для формирования русских названий столбцов таблицы. Методы "перекидывают"
    //// данные с оригинальной сущности на этот класс, и далее этот класс добавляется
    //// в List, который уже отправляется на сортировку и вывод в DataGridView. До создания
    //// этого класса я пытался обойтись без него, создавая в методах новый анонимный тип, с 
    //// приписанными русскими названиями столбцов, однако невозможно создать метод, возвращающий 
    //// анонимный тип. А без создания методов - в коде будет ад: все будет дублироваться, а также
    //// станет невозможно выделить логику в отдельный преокт.
    public class DiagnosisForRussianTitles
    {
        public int? Порядковый_номер { get; set; }
        public string Наименование { get; set; }
        public string Код_МКБ { get; set; }
    }
}

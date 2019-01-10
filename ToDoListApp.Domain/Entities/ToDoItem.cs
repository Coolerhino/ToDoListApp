using System;
using ToDoListApp.Domain.Enums;

namespace ToDoListApp.Domain.Entities
{
    public class ToDoItem
    {
        public int ToDoItemId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime EstimatedFinish { get; set; }
        public bool Done { get; set; }
        //mozna dodac do viewmodelu kalkulacje czasu ktory pozostal do wykonania taska
        //mozna oddzielnei zrobic przewidywana date i date wykonania
        //i w wyswietlaniu pojedynczego itemu wyswietlac (jeszcze nie wykonane / data wykonania)
    }
}
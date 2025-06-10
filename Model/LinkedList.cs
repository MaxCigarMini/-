using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Linked_list.Model
{
    /// <summary>
    /// Односвязный список
    /// </summary>
    internal class LinkedList<T> : IEnumerable<T>
    {
        /// <summary>
        /// Первый элемент списка
        /// </summary>
        public Item<T> Head { get; private set; }
        /// <summary>
        /// Последний элемент списка
        /// </summary>
        public Item<T> Tail { get; private set; }
        /// <summary>
        /// Количестиво элементов списка
        /// </summary>
        public int Count { get; private set; }
        /// <summary>
        /// Создание пустого списка
        /// </summary>
        public LinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        /// <summary>
        /// Создать список с начальным элементом
        /// </summary>
        public LinkedList(T data)
        {
            SetHeadAndTail(data);
        }
        /// <summary>
        /// Добавить данные в конец списка
        /// </summary>
        public void Add(T data)
        {

            if (Tail != null)
            {
                var item = new Item<T>(data);
                Tail.Next = item; //Прицепили элемент
                Tail = item; // Определили как замыкающий
                Count++;
            }
            else
            {
                SetHeadAndTail(data);
            }
        }
        public void Delete(T data)
        {
            if (Head != null)
            {
                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }

                var current = Head.Next;
                var previous = Head;

                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }
                    previous = current;
                    current = current.Next;
                }
            }
            else
            {
                SetHeadAndTail(data);
            }
        }
        /// <summary>
        /// Добавить данные в ... списка
        /// </summary>
        public void AppendHead(T data)
        {
            var item = new Item<T>(data);
            item.Next = Head;
            Head = item;
            Count++;
        }
        public void InsertAfter(T target, T data)
        {
            if (Head != null)
            {                
                var current = Head;
                while (current != null)
                {

                    if (current.Data.Equals(target))
                    {
                        var item = new Item<T>(data);
                        item.Next = current.Next;
                        current.Next = item;
                        if (current == Tail)
                            Tail = item;

                        Count++;
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
            else
            {
                // Нужно решить, если список пустой - не добовлять ничего, либо вставить данные               
            }
        }
        public void Replace(T target, T data)
        {
            var current = Head;
            while (current != null)
            {
                if (current.Data.Equals(target))
                {
                    current.Data = data;
                    return;
                }
                current = current.Next;
            }
        }
        private void SetHeadAndTail(T data) // Приватная установка значения
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }
        public IEnumerator<T> GetEnumerator() //Получить Перечисление всех элементов списка
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator() //Явная реализация
        {
            return GetEnumerator();
        }
        public override string ToString()
        {
            return "Linked List" + Count + "элементов";
        }
    }
}

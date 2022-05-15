using System;

namespace lesson_4
{
    /// <summary>
    /// Описание здания.
    /// </summary>
    internal class Building
    {
        /// <summary>
        /// Номер здания.
        /// </summary>
        static private int _number;

        /// <summary>
        /// Высота здания. Определяется в метрах.
        /// </summary>
        private int _heigth;

        /// <summary>
        /// Количество этажей в здании.
        /// </summary>
        private int _floor;

        /// <summary>
        /// Количество квартир в здании.
        /// </summary>
        private int _numberOfApartament;

        /// <summary>
        /// Количество подъездов в здании.
        /// </summary>
        private int _numberOfEntances;


        public Building()
        {
            _number += 10;
        }

        /// <summary>
        /// Данные здания.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"█ Номер здания: {(_number == 0 ? "Нет данных" : _number.ToString())}\n" +
                   $"█ Высота здания: {(_heigth == 0 ? "Нет данных" : _heigth.ToString() + " м.")}\n" +
                   $"█ Количество этажей: {(_floor == 0 ? "Нет данных" : _floor.ToString())}\n" +
                   $"█ Количество квартир: {(_numberOfApartament == 0 ? "Нет данных" : _numberOfApartament.ToString())}\n" +
                   $"█ Количество подъездов: {(_numberOfEntances == 0 ? "Нет данных" : _numberOfEntances.ToString())}\n";
        }

        /// <summary>
        /// Заполнение данных.
        /// </summary>
        /// <param name="heigth"> Высота здания. </param>
        /// <param name="floor"> Количество этажей в здании. </param>
        /// <param name="numberOfApartament"> Количество квартир в здании. </param>
        /// <param name="numberOfEntances"> Количество подъездов в здании. </param>
        public void SetDataBuild(int heigth, int floor, int numberOfApartament, int numberOfEntances)
        {
            _heigth = heigth;
            _floor = floor;
            _numberOfApartament = numberOfApartament;
            _numberOfEntances = numberOfEntances;
        }

        /// <summary>
        /// Вычесление высоты этажа в здании.
        /// </summary>
        public void CulculateHeigthFloors()
        {
            int heigthFloors = _heigth / _floor;
            Console.WriteLine($"Высота этажей в здании № {_number} = {heigthFloors} м.");
        }

        /// <summary>
        /// Вычесление количества квартир в одном подъезде здания.
        /// </summary>
        public void CulculateApartmentsInEntrance()
        {
            int numberOfApartments = _numberOfApartament / _numberOfEntances;
            Console.WriteLine($"Количество квартир в одном подъезде здания № {_number} = {numberOfApartments}");
        }

        /// <summary>
        /// Вычесление количества квартир на одном этаже здания.
        /// </summary>
        public void CulculateApartmentsInFloor()
        {
            int apartmentsInEntrance = _numberOfApartament / _numberOfEntances;
            int apartamentsInFloor = apartmentsInEntrance / _floor;
            Console.WriteLine($"Количество квартир на одном этаже в здании № {_number} = {apartamentsInFloor}");
        }

        /// <summary>
        /// Увеличение значения номера.
        /// </summary>
        public void ChangeBuildingNumber()
        {
            _number += 1;
        }
    }
}

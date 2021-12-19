using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_15
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Члены арифметической прогрессии:");
            ArithProgression arithProgression = new ArithProgression();
            arithProgression.setStart(3);
            arithProgression.setStep(5);
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            arithProgression.reset();
           
            Console.WriteLine("Члены геометрической прогрессии:");
            GeomProgression geomProgression = new GeomProgression();
            geomProgression.setStart(1);
            geomProgression.setStep(4);
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            geomProgression.reset();
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());

            Console.ReadKey();
        }
    }
}
interface ISeries //интерфейс для генерации ряда чисел
{
    void setStart(int x); //устанавливает начальное значение (метод имеет только название, список параметров и тип возвращаемого значения, не имеет реализации)
    int getNext(); //метод возвращает следующее число ряда
    void reset(); //метод выполняет сброс к начальному значению
}
class ArithProgression : ISeries  // класс Ариф - реализация интерфейса
{
    int startValue;  //поле начального значения
    int surrentValue; //поле промежуточного значения
    int step; //шаг

    public int getNext() //метод getNext добавляющий шаг к промжуточному значению (реализующий следующий член прогрессии)
    {
        surrentValue += step;
        return surrentValue;
    }
    public void reset() //метод reset сбрасывает промежуточное значение обратно на стартовое
    {
        surrentValue=startValue;
    }
    public void setStart(int x) //метод реализует первый член прогрессии (стартовое значение)
    {
        startValue=x;
        surrentValue = startValue;
    }
    public void setStep(int s) //метод реализует шаг
    {
        step = s;
    }

}
class GeomProgression : ISeries  // класс Геом - реализация интерфейса
{
    int startValue;  //поле начального значения
    int surrentValue; //поле промежуточного значения
    int step; //шаг

    public int getNext()  //метод getNext добавляющий шаг к промжуточному значению (реализующий следующий член прогрессии)
    {
        surrentValue *= step;
        return surrentValue;
    }
    public void reset() //метод reset сбрасывает промежуточное значение обратно на стартовое
    {
        surrentValue = startValue;
    }
    public void setStart(int x) //метод реализует первый член прогрессии (стартовое значение)
    {
        startValue = x;
        surrentValue = startValue;
    }
    public void setStep(int s) //метод реализует шаг
    {
        step = s;
    }

}



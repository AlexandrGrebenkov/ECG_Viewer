using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECG_Viewer.Filtration
{
    public class WindowFilter
    {
        /// <summary>Импульсная характеристика</summary>
        double[] H;
        /// <summary>Буфер входных значений</summary>
        double[] Xn;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fd">Частота дискретизации</param>
        /// <param name="fs">Частота среза</param>
        /// <param name="m">Размер окна</param>
        /// <param name="window">Тип окна</param>
        public WindowFilter(double fd, double fs, int m, WindowType window)
        {
            H = new double[m];
            Xn = new double[m];

            // Приведённая частота (в диапазоне от 0 до 0,5):
            double fc = fs / fd;

            // Определяем весовые коэффициенты характеристики
            double h;
            for (int i = 0; i < H.Length; i++)
            {
                if (i - m / 2 == 0)
                    h = 2 * Math.PI * fc;
                else
                    h = Math.Sin(2 * Math.PI * fc * (i - m / 2)) / (i - m / 2);

                if (window == WindowType.Hamming)
                    H[i] = h * GetHammingWindow(i, m);
                else
                    H[i] = h * GetBlackmanWindow(i, m);
            }

            // Нормировка импульсной характеристики
            double SUM = 0;
            for (int i = 0; i < m; i++)
                SUM += H[i];
            for (int i = 0; i < m; i++)
                H[i] /= SUM; // сумма коэффициентов должна равняться 1

            for (int i = 0; i < m; i++) // Обнуляем буфер
                Xn[i] = 0;
        }

        /// <summary>Фильтрация по точкам</summary>
        /// <param name="a">Новое входное значение</param>
        /// <returns>Отфильтрованное значение</returns>
        public double FilterNext(double a)
        {
            for (int i = 0; i < Xn.Length - 1; i++)
                Xn[i] = Xn[i + 1]; // Сдвигаем весь массив
            Xn[Xn.Length - 1] = a; // И дописываем новое число

            // Фильтрация входных данных
            double result = 0;
            for (int j = 0; j < Xn.Length - 1; j++) // свёртка
                result += H[j] * Xn[j];
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data">Входные данные</param>
        /// <param name="Fd">Частота дискретизации</param>
        /// <param name="Fs">Частота среза</param>
        /// <param name="M">Порядок фильтра</param>
        /// <returns></returns>
        public static double[] Filter(float[] data, double Fd, double Fs, int M, WindowType window)
        {
            //Импульсная характеристика:
            var H = new double[M];
            //Приведённая частота (в диапазоне от 0 до 0,5):
            double Fc = Fs / Fd;

            //Определяем весовые коэффициенты характеристики
            double h;
            for (int i = 0; i < H.Length; i++)
            {
                if (i - M / 2 == 0)
                    h = 2 * Math.PI * Fc;
                else
                    h = Math.Sin(2 * Math.PI * Fc * (i - M / 2)) / (i - M / 2);

                if (window == WindowType.Hamming)
                    H[i] = h * GetHammingWindow(i, M);
                else
                    H[i] = h * GetBlackmanWindow(i, M);
            }

            //Нормировка импульсной характеристики
            double SUM = 0;
            for (int i = 0; i < M; i++)
                SUM += H[i];
            for (int i = 0; i < M; i++)
                H[i] /= SUM; //сумма коэффициентов должна равняться 1


            double[] Out = new double[data.Length];
            var average = data.Take(10).Average(); // Для значений предшествующих записи. Считаем среднее по первым
                                                   // 10 точкам и предполагаем, что предыдущие отсчёты были такими же

            //Фильтрация входных данных
            for (int i = 0; i < Out.Length; i++)
            {
                Out[i] = 0;
                for (int j = 0; j < M - 1; j++) // свёртка
                    if (i - j > 0)
                        Out[i] += H[j] * data[i - j];
                    else
                        Out[i] += H[j] * average;
            }

            return Out;
        }

        static double GetBlackmanWindow(int i, int M)
        {
            return 0.42 - 0.5 * Math.Cos((2 * Math.PI * i) / M) + 0.08 * Math.Cos((4 * Math.PI * i) / M);
        }

        static double GetHammingWindow(int i, int M)
        {
            return 0.54 - 0.46 * Math.Cos((2 * Math.PI * i) / M);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        

        internal static int Add(int a, int b)
        {
            return a+b;
        }

        internal static bool IsMajeur(int age) //verif enrtre 0 150
        {
            if (age < 0 || age >= 150)
            {
                throw new ArgumentException("Age entre 0 et 150 !");
            }
            return (age >= 18);
        }

        internal static bool IsEven(int a) //verif modulo 0
        {
            if (a % 2 == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }
        internal static bool IsDivisible(int a, int b) //verif modulo 0
        {
            if (a % b == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        internal static bool IsPrimary(int a) //verif divisible + 0 et 1 non premiers + verif pour chaque division (/1;/2;...)
        {
            if (a < 2)
            {
                return false; 
            }

            for (int i = 2; i < a; i++) 
            {
                if (IsDivisible(a, i))
                {
                    return false;
                }
            }
            return true;
        }
        internal static List<int> GetAllPrimary(int a) //verif premiers + ajouter dans la liste
        {
            List<int> premiers = new List<int>();

            for (int i = 2; i <= a; i++)
            {
                if (IsPrimary(i))
                {
                    premiers.Add(i);
                }
            }
            return premiers;
        }
        internal static int Power2(int a)
        {
            return a*a;
        }
        internal static int Power(int a, int b) //recursivité 
        {
            if (b == 0) 
            {
                return 1;
            }
            if (b == 1) 
            { 
                return a; 
            }
 
            return a*Power(a,b-1);
        }
        internal static bool IsInOrder(int a, int b)
        {
            if (a <= b)
            {
                return true;
            } else
            {
                return false;
            }
        }
        internal static bool IsListInOrder(List<int> list) // IsInOrder : list[i] et list[i + 1]
        {
            if (list == null || list.Count <= 1)
            {
                return true;
            }

            for (int i = 0; i < list.Count - 1; i++)
            {
                if (!IsInOrder(list[i], list[i + 1]))
                {
                    return false;
                }
            }
            return true;
        }
        internal static List<int> Sort(List<int> toSort) //copie liste -> parcourir toute la liste -> verif que le nombre actuelle est plus grand que le nombre d'apres (list[j] < list[j+1]) -> echanger element
        {
            List<int> listeTriee = new List<int>(toSort);

            for (int i = 0; i < listeTriee.Count - 1; i++)
            {
                for (int j = 0; j < listeTriee.Count - 1; j++)
                {
                    if (listeTriee[j] > listeTriee[j + 1])
                    {
                        int temp = listeTriee[j];
                        listeTriee[j] = listeTriee[j + 1];
                        listeTriee[j + 1] = temp;
                    }
                }
            }

            return listeTriee;
        }

        // Faire si j'ai le temps après

        internal static bool IsInOrderDesc(int arg1, int arg2)
        {
            if (arg1 >= arg2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        internal static List<int> GenericSort(List<int> toSort, Func<int, int, bool> isInOrder)
        {
            if (toSort == null || toSort.Count == 0)
            {
                throw new ArgumentException("liste null ou vide");
            }

            List<int> listeTriee = new List<int>(toSort);


            for (int i = 0; i < listeTriee.Count - 1; i++)
            {
                for (int j = 0; j < listeTriee.Count - 1 - i; j++)
                {
                    if (!isInOrder(listeTriee[j], listeTriee[j + 1]))
                    {
                        int temp = listeTriee[j];
                        listeTriee[j] = listeTriee[j + 1];
                        listeTriee[j + 1] = temp;
                    }
                }
            }

            return listeTriee;
        }
    }
}

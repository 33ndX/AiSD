	using System;
	using System.Collections.Concurrent;
	using System.Collections.Generic;
	using System.Linq;
	using System.Runtime.InteropServices;
	using System.Security.Cryptography.X509Certificates;
	using System.Text;
	using System.Threading.Tasks;

	namespace Projekt0
	{
    		class Program
    		{
       
       

        		static void Main(string[] args)
        		{
           
            
           

        		}
    		   }
	}



	static int[] RandTab(int n, int min, int max)
	{
		int[] tab = new int[n];
		Random rand = new Random();
		for (int i = 0; i < n; i++)
		{ 
			tab[i] = rand.Next(min, max);
        }
		return tab;
	} 

	static void BubbleSort(int[] tab)
	{
		int n = tab.Length;
		for(int i = 0; i < n - 1; i++)
		{
			for (int j = 0; j < n - i - 1;j++)
			{
				if (tab[j] < tab[j + 1])
				{
					var tempVar = tab[j];
					tab[j] = tab[j + 1];
					tab[j + 1] = tempVar;
				}
			}
		}
	}

	static void InsertSort(int[] tab)
	{
		int n = tab.Length;
		for(int i=1; i<n; i++){
			int key = tab[i];
			int j = i-1;
			while (j >= 0 && tab[j] > key)
			{
				tab[j+1] = tab[j];
				j--;
			}
			tab[j+1] = key;
		}
	}

	static void CountingSort(int[] tab)
	{
		int max = tab.Max();
		int[] tab2 = new int[max+1];

		for(int i=0; i<tab.Length; i++)
		{
			tab2[tab[i]]++;
		}

		for(int i=0, j=0; i<=max; i++)
		{
			while (tab2[i] > 0)
			{
				tab[j] = i;
				j++;
				tab2[i]--;
			}
		}
	}

	static void QuickSort(int[] tab, int left, int right)
	{
		if(left < right)
		{
			int pivot = Partition(tab, left, right);
			QuickSort(tab, left, pivot);
			QuickSort(tab, pivot + 1, right);
		}
	}

	static int Partition(int[] tab, int left, int right)
	{
		int x = tab[left];
		while (true)
		{
			while (tab[left] < x)
			{
				left++;
			}
			while (tab[right] > x)
			{
				right--;
			}
			if (left < right)
			{
				if (tab[left] == tab[right]) { return right; }

				var tempVar = tab[left];
				tab[left] = tab[right];
				tab[right] = tempVar;
			}
			else return right;
		}
	}

	static void MergeSort(int[] tab, int left, int right)
	{
		if(left < right)
		{
			int middle = left + (right - left) / 2;
			MergeSort(tab, left, middle);
			MergeSort(tab, middle + 1, right);
			Merge(tab, left, middle, right);
		}
	}

	static void Merge(int[] tab, int left, int middle, int right)
	{
		int leftIndex = left;
		int rightIndex = middle + 1;

		int[] merged = new int[left - right + 1];
		int mergedIndex = 0;

		while(leftIndex <= middle && rightIndex <= right)
		{
			if (tab[leftIndex] <= tab[rightIndex])
			{
				merged[mergedIndex++] = tab[leftIndex++];
			}
			else
			{
                merged[mergedIndex++] = tab[rightIndex++];
            }
		}

		
	}

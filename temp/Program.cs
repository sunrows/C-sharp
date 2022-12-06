// for (int i=0;i<raw;i++)     
//   {  
//   for(int j=0;j<col;j++)     
//     {    
//     for (int k=col-1;k>j;k--)    
//       if (a[i][k]<a[i][k-1])    
//        {    
//         int tmp=a[i][k];    
//         a[i][k]=a[i][k-1];    
//         a[i][k-1]=tmp;  
//        }        
//         cout<<a[i][j]<<" ";  
//     }  
//   cout <<"\n";  
//  }  
// }

int [,] arr = {{5,7,1,5,8},{8,9,3,6,4},{7,9,4,5,1}};


for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = arr.GetLength(1) - 1; k > j; k--)
            if (arr[i, k] > arr[i, k - 1])
            {
                int tmp = arr[i, k];
                arr[i, k] = arr[i, k - 1];
                arr[i, k - 1] = tmp; ;
            }
        Console.Write($"{arr[i, j]} \t");
    }
    Console.WriteLine();
}

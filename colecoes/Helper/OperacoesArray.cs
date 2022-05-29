namespace colecoes.Helper
{
    public class OperacoesArray
    {
        public void ImprimirArray(int[] array){
            var linha = String.Join(", ",array);
            // for (int i = 0; i < array.Length; i++)
            // {
            //     System.Console.WriteLine(array[i]);
            // }
               System.Console.WriteLine(linha);
        }

        public void OrdenarBubbleSort(ref int[] array){
            int temp =0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length-1; j++)
                {
                    if (array[j] > array[j+1]) {
                        temp=array[j+1];
                        array[j+1] = array[j];
                        array[j] = temp;
                    }
                }

                
            }
        }

        
        public void OrdenarBubbleSort2(ref int[] array){
            int temp =0;
           
                for (int j = 0; j < array.Length-1; j++)
                {
                    if (array[j] > array[j+1]) {
                        temp=array[j+1];
                        array[j+1] = array[j];
                        array[j] = temp;
                    }
                }

                
            
        }

        public void OrdenarArray(ref int[] array){
            Array.Sort(array);

        }

        public void Copiar(ref int[] array, ref int[] arrayDestino){
            Array.Copy(array,arrayDestino,array.Length);
        }

        public bool Existe(int[] array, int valor){
            return Array.Exists(array,elemento => elemento == valor);
        }

        public bool TodosMaiorQue(int[] array, int valor){

            return Array.TrueForAll(array,elemento => elemento>valor);
        }

        public int ObterValor(int[] array, int valor){
            return Array.Find(array,elemento => elemento == valor);
        }

        public int ObterIndice(int[] array, int valor){
            return Array.IndexOf(array, valor);
        }

        public void RedimensionarArray(ref int[] array, int novotamanho){
            Array.Resize(ref array, novotamanho);
        }

        public string[] ConverterArrayString(int[] array){
            return Array.ConvertAll(array, elemento => elemento.ToString());
        }

        
    }
}
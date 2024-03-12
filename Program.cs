namespace ArbolBalanceado
{
	public class ArbolBalanceado
	{
		class Nodo
		{
			public int info;
			public Nodo izq, der;
		}

		Nodo raiz;

		public ArbolBalanceado()
		{
			raiz = null;
		}

		public void Insertar(int info)
		{
			Nodo nuevo;
			nuevo = new Nodo();
			nuevo.info = info;
			nuevo.izq = null;
			nuevo.der = null;

			if (raiz == null)
				raiz = nuevo;
			else
			{
				Nodo anterior = null, reco;
				reco = raiz;

				while (reco != null)
				{
					anterior = reco;
					if (info < reco.info)
						reco = reco.izq;
					else
						reco = reco.der;
				}

				if (info < anterior.info)
					anterior.izq = nuevo;
				else
					anterior.der = nuevo;
			}
		}

		public void ImprimirPre()
		{
			ImprimirPre(raiz);
			Console.WriteLine();
		}

		private void ImprimirPre(Nodo reco)
		{
			if (reco != null)
			{
				Console.Write(reco.info + " ");
				ImprimirPre(reco.izq);
				ImprimirPre(reco.der);
			}
		}

		public void ImprimirEntre()
		{
			ImprimirEntre(raiz);
			Console.WriteLine();
		}

		private void ImprimirEntre(Nodo reco)
		{
			if (reco != null)
			{
				ImprimirEntre(reco.izq);
				Console.Write(reco.info + " ");
				ImprimirEntre(reco.der);
			}
		}

		public void ImprimirPost()
		{
			ImprimirPost(raiz);
			Console.WriteLine();
		}

		private void ImprimirPost(Nodo reco)
		{
			if (reco != null)
			{
				ImprimirPost(reco.izq);
				ImprimirPost(reco.der);
				Console.Write(reco.info + " ");
			}
		}

		private void ImprimirConDiagonales(Nodo reco, string prefijo)
		{
			if (reco != null)
			{
				Console.WriteLine($"{prefijo}└── {reco.info}");
				ImprimirConDiagonales(reco.izq, $"{prefijo}    \\");
				ImprimirConDiagonales(reco.der, $"{prefijo}     ");
			}
		}

		private void ImprimirConDiagonales(Nodo reco, string prefijo, bool esIzquierdo)
		{
			if (reco != null)
			{
				Console.WriteLine($"{prefijo} {(esIzquierdo ? "└── " : "├── ")} {reco.info}");
				ImprimirConDiagonales(reco.izq, $"{prefijo} {(esIzquierdo ? "    " : "│   ")}", true);
				ImprimirConDiagonales(reco.der, $"{prefijo} {(esIzquierdo ? "│   " : "    ")}", false);
			}
		}

		static void Main(string[] args)
		{
			ArbolBalanceado abo = new ArbolBalanceado();
			int opcion;

			do
			{
				Console.WriteLine("1. Insertar un valor");
				Console.WriteLine("2. Imprimir con diagonales");
				Console.WriteLine("3. Recorrido preorden");
				Console.WriteLine("4. Recorrido inorden");
				Console.WriteLine("5. Recorrido postorden");
				Console.WriteLine("0. Salir");

				Console.Write("Ingrese la opción: ");
				opcion = Convert.ToInt32(Console.ReadLine());

				switch (opcion)
				{
					case 1:
						Console.Write("Ingrese el valor a insertar: ");
						int valor = Convert.ToInt32(Console.ReadLine());
						abo.Insertar(valor);
						break;
					case 2:
						Console.WriteLine("Impresion con diagonales: ");
						abo.ImprimirConDiagonales(abo.raiz, "", true);
						break;
					case 3:
						Console.WriteLine("Recorrido preorden: ");
						abo.ImprimirPre();
						break;
					case 4:
						Console.WriteLine("Recorrido inorden: ");
						abo.ImprimirEntre();
						break;
					case 5:
						Console.WriteLine("Recorrido postorden: ");
						abo.ImprimirPost();
						break;
					default:
						Console.WriteLine("Escoge el número correcto");
						break;
				}
			} while (opcion != 0);
		}
	}
}



//YA JALA
//namespace ArbolBinarioOrdenado1
//{
//	public class ArbolBinarioOrdenado
//	{
//		class Nodo
//		{
//			public int info;
//			public Nodo izq, der;
//		}

//		Nodo raiz;

//		public ArbolBinarioOrdenado()
//		{
//			raiz = null;
//		}

//		public void Insertar(int info)
//		{
//			Nodo nuevo;
//			nuevo = new Nodo();
//			nuevo.info = info;
//			nuevo.izq = null;
//			nuevo.der = null;

//			if (raiz == null)
//				raiz = nuevo;
//			else
//			{
//				Nodo anterior = null, reco;
//				reco = raiz;

//				while (reco != null)
//				{
//					anterior = reco;
//					if (info < reco.info)
//						reco = reco.izq;
//					else
//						reco = reco.der;
//				}

//				if (info < anterior.info)
//					anterior.izq = nuevo;
//				else
//					anterior.der = nuevo;
//			}
//		}

//		private void ImprimirPre(Nodo reco)
//		{
//			if (reco != null)
//			{
//				Console.Write(reco.info + " ");
//				ImprimirPre(reco.izq);
//				ImprimirPre(reco.der);
//			}
//		}

//		public void ImprimirPre()
//		{
//			ImprimirPre(raiz);
//			Console.WriteLine();
//		}

//		private void ImprimirEntre(Nodo reco)
//		{
//			if (reco != null)
//			{
//				ImprimirEntre(reco.izq);
//				Console.Write(reco.info + " ");
//				ImprimirEntre(reco.der);
//			}
//		}

//		public void ImprimirEntre()
//		{
//			ImprimirEntre(raiz);
//			Console.WriteLine();
//		}

//		private void ImprimirPost(Nodo reco)
//		{
//			if (reco != null)
//			{
//				ImprimirPost(reco.izq);
//				ImprimirPost(reco.der);
//				Console.Write(reco.info + " ");
//			}
//		}

//		public void ImprimirPost()
//		{
//			ImprimirPost(raiz);
//			Console.WriteLine();
//		}

//		static void Main(string[] args)
//		{
//			ArbolBinarioOrdenado abo = new ArbolBinarioOrdenado();
//			int opcion;

//			do
//			{
//				Console.WriteLine("1. Insertar un valor");
//				Console.WriteLine("2. Imprimir preorden");
//				Console.WriteLine("3. Imprimir entreorden");
//				Console.WriteLine("4. Imprimir postorden");
//				Console.WriteLine("0. Salir");

//				Console.Write("Ingrese la opción: ");
//				opcion = Convert.ToInt32(Console.ReadLine());

//				switch (opcion)
//				{
//					case 1:
//						Console.Write("Ingrese el valor a insertar: ");
//						int valor = Convert.ToInt32(Console.ReadLine());
//						abo.Insertar(valor);
//						break;
//					case 2:
//						Console.WriteLine("Impresion preorden: ");
//						abo.ImprimirPre();
//						break;
//					case 3:
//						Console.WriteLine("Impresion entreorden: ");
//						abo.ImprimirEntre();
//						break;
//					case 4:
//						Console.WriteLine("Impresion postorden: ");
//						abo.ImprimirPost();
//						break;
//				}
//			} while (opcion != 0);
//		}
//	}
//}

//namespace ArbolesPrologU2
//{
//	public partial class Form1 : Form
//	{
//		private TreeNode root;

//		public Form1()
//		{
//			InitializeComponent();
//			root = null;

//		}

//		private void btnCreateTree_Click(object sender, EventArgs e)
//		{
//			int value;
//			if (int.TryParse(txtValue.Text, out value))
//			{
//				Insert(root, value);
//				treeView.Nodes.Clear();
//				treeView.Nodes.Add(root);
//				treeView.ExpandAll();
//			}
//			else
//			{
//				MessageBox.Show("Por favor, ingrese un valor válido.");
//			}
//		}

//		private TreeNode Insert(TreeNode node, int value)
//		{
//			if (root == null)
//				root = new TreeNode(value.ToString());
//			if (node == null)
//			{
//				return new TreeNode(value.ToString());
//			}

//			if (value < int.Parse(node.Text))
//			{
//				node.Nodes.Add(Insert(node, value));
//			}
//			else if (value > int.Parse(node.Text))
//			{
//				node.Nodes.Add(Insert(node, value));
//			}
//			else
//			{
//				MessageBox.Show("El valor ya existe en el árbol.");
//			}

//			return node;
//		}

//		private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
//		{

//		}
//	}


//}

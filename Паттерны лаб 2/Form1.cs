using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Паттерны_лаб_2.Matrices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Паттерны_лаб_2
{
    public partial class Form1 : Form
    {
        private IMatrix matrix;
        private IMatrix tempmatrix;
        private IDrawer consoleDrawer;
        private IDrawer graphicsDrawer;

        private bool showBord;
        private bool showShadow;

        public Form1()
        {           
            InitializeComponent();
            matrix = new UsualMatrix(3, 3); //cтрочки, столбики
            consoleDrawer = new ConsoleDrawer(textBox1);
            graphicsDrawer = new GraphicsDrawer(panel1.CreateGraphics());
        }

        private void GenerationUsual_Click(object sender, EventArgs e)
        {    
            HorizontalGroupMatrix matrix1Temp = new HorizontalGroupMatrix();       
            IMatrix temp1 = new UsualMatrix(2, 2);
            MatrixInitializer.Fill(temp1, 3, 9); //nonZero, maxValue
            IMatrix temp2 = new UsualMatrix(3, 4);
            MatrixInitializer.Fill(temp2, 5, 9);
            IMatrix temp3 = new SparseMatrix(4, 3);
            MatrixInitializer.Fill(temp3, 7, 9);
            matrix1Temp.AddMatrix(temp1);
            matrix1Temp.AddMatrix(temp2);
            matrix1Temp.AddMatrix(temp3);

            IMatrix matrix1 = matrix1Temp;
            matrix1 = new TransposingMatrixDecorator(matrix1);

            matrix = matrix1;
            UpdateVisualization();      

        }

        private void GenerationSparse_Click(object sender, EventArgs e)
        {
            HorizontalGroupMatrix matrix1Temp = new HorizontalGroupMatrix();
            IMatrix temp1 = new SparseMatrix(2, 2);
            MatrixInitializer.Fill(temp1, 1);
            IMatrix temp2 = new SparseMatrix(4, 3);
            MatrixInitializer.Fill(temp2, 2);
            IMatrix temp3 = new SparseMatrix(1, 3);
            MatrixInitializer.Fill(temp3, 3);
            matrix1Temp.AddMatrix(temp1);
            matrix1Temp.AddMatrix(temp2);
            matrix1Temp.AddMatrix(temp3);
            IMatrix matrix1 = matrix1Temp;
            matrix1 = new TransposingMatrixDecorator(matrix1);

            HorizontalGroupMatrix matrix2Temp = new HorizontalGroupMatrix();
            IMatrix temp21 = new SparseMatrix(2, 4);
            MatrixInitializer.Fill(temp21, 4);
            IMatrix temp22 = new SparseMatrix(2, 3);
            MatrixInitializer.Fill(temp22, 5);
            matrix2Temp.AddMatrix(temp21);
            matrix2Temp.AddMatrix(temp22);
            IMatrix matrix2 = matrix2Temp;
            matrix2 = new TransposingMatrixDecorator(matrix2);

            IMatrix matrix3 = new SparseMatrix(1, 1);
            MatrixInitializer.Fill(matrix3, 6);

            HorizontalGroupMatrix matrixTemp = new HorizontalGroupMatrix();
            matrixTemp.AddMatrix(matrix1);
            matrixTemp.AddMatrix(matrix2);
            matrixTemp.AddMatrix(matrix3);

            matrix = matrixTemp;
            matrix = new TransposingMatrixDecorator(matrix);

            UpdateVisualization();
        }

        private void Renumber_Click(object sender, EventArgs e)
        {
            RenumberingMatrixDecorator matrixTemp = new RenumberingMatrixDecorator(matrix);

            matrixTemp.RenumberingRows();
            matrixTemp.RenumberingColumns();

            tempmatrix = matrix;
            matrix = matrixTemp;

            UpdateVisualization();
            matrix = tempmatrix;
        }

        private void Recover_Click(object sender, EventArgs e)
        {
            RenumberingMatrixDecorator matrixTemp = new RenumberingMatrixDecorator(matrix);

            matrixTemp.RecoverRows();
            matrixTemp.RecoverColumns();

            matrix = matrixTemp;
            UpdateVisualization();
        }

        private void UpdateVisualization()
        {
            IDrawer ConsoleTempDrawer = consoleDrawer;
            IDrawer GraphicsTempDrawer = graphicsDrawer;

            if (showBord)
            {
                ConsoleTempDrawer = new ConsoleBordDecorator(ConsoleTempDrawer, textBox1);
                GraphicsTempDrawer = new GraphicsBordDecorator(GraphicsTempDrawer, panel1.CreateGraphics());
            }

            if (showShadow)
            {
                ConsoleTempDrawer = new ConsoleShadowDecorator(ConsoleTempDrawer, textBox1);
                GraphicsTempDrawer = new GraphicsShadowDecorator(GraphicsTempDrawer, panel1.CreateGraphics());
            }

            if (showBord && showShadow)
            {
                ConsoleTempDrawer = new ConsoleBordShadowDecorator(ConsoleTempDrawer, textBox1);
                GraphicsTempDrawer = new GraphicsBordShadowDecorator(GraphicsTempDrawer, panel1.CreateGraphics());
            }

            matrix.Draw(ConsoleTempDrawer);
            matrix.Draw(GraphicsTempDrawer);
        }

        private void Bord_CheckedChanged(object sender, EventArgs e)
        {
            if (Bord.Checked == true)
            {
                showBord = true;
            }
            else
            {
                showBord = false;
            }

            UpdateVisualization();
        }

        private void Shadow_CheckedChanged(object sender, EventArgs e)
        {
            if (Shadow.Checked == true)
            {
                showShadow = true;
            }
            else
            {
                showShadow = false;
            }

            UpdateVisualization();
        }      
    }
}

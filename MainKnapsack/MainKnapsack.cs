using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainKnapsack
{
    public partial class MainKnapsack : Form
    {
        public static int capacity = new int();
        public static int numberOfItems = new int();
        public static int populationSize = new int();
        public static int numberOfGenerations = new int();
        public static double crossoverProbability = new double();
        public static double mutationProbability = new double();
        public static int currentGeneration = new int();
        public static int currentChromosome = new int();
        public static int bestFitnessIndex = new int();
        public static double bestFitnessValue = new double();
        public static int bestFitnessQuantity = new int();
        public static double bestFitnessWeight = new double();
        public static int bestSolutionIndex = new int();
        public static double bestSolutionValue = new double();
        public static int bestSolutionQuantity = new int();
        public static double bestSolutionWeight = new double();
        public static int parentIndex1 = new int();
        public static int parentIndex2 = new int();

        public static double[] weightsTemplate = new double[50];
        public static double[] valuesTemplate = new double[50];
        public static double[] capacityTemplate = new double[4];

        public static double[] weights;
        public static double[] values;
        public static double[] fitness;
        public static double[] sumOfWeights;
        public static int[] quantityOfItems;
        public static double[] selectionProbability;
        public static double[,] probabilityDiapason;
        public static bool[,] population;
        public static bool[,] newPopulation;
        public static List<double> bestHis = null;

        public double[,] arr = new double[50, 2];
        public static Random rnd = new Random();

        public MainKnapsack()
        {
            InitializeComponent();
        }


        private double[,] getData(string filename)
        {
            double[,] kq;
            int row = 0;
            int col = 0;
            string[] lines = File.ReadAllLines(filename);
            row = lines.Length;
            col = lines[0].Split(' ').Length;
            kq = new double[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    kq[i, j] = Double.Parse(lines[i].Split(' ')[j]);
                }
            }
            return kq;
        } 
        
        private void btnData_Click(object sender, EventArgs e)
        {
            OpenFileDialog data = new OpenFileDialog();
            if (data.ShowDialog() == DialogResult.OK)
            {
                arr = getData(data.FileName);
                textBox2.Text = arr[0, 0].ToString();
                textBox3.Text = arr[0, 1].ToString();
                for(int i=0;i<arr[0,0];i++)
                {
                    valuesTemplate[i] = arr[i + 1, 0];
                }
                for (int j = 0; j < arr[0, 0]; j++)
                {
                    weightsTemplate[j] = arr[j+1, 1];
                }
            }

            button2.Visible = Visible;
            button3.Visible = Visible;
            label20.Visible = false;
            //khoi tao gia tri dau vao
            numberOfItems = Convert.ToInt32(textBox2.Text);
            capacity = Convert.ToInt32(textBox3.Text);
            populationSize = Convert.ToInt32(numericUpDown3.Value);
            numberOfGenerations = Convert.ToInt32(numericUpDown4.Value);
            crossoverProbability = Convert.ToInt32(numericUpDown2.Value);
            mutationProbability = Convert.ToInt32(numericUpDown1.Value);
            currentGeneration = 0;
            label15.Text = currentGeneration.ToString();

            //khoi tao mang
            population = new bool[numberOfItems, populationSize];
            fitness = new double[populationSize];
            sumOfWeights = new double[populationSize];
            quantityOfItems = new int[populationSize];
            selectionProbability = new double[populationSize];
            weights = new double[numberOfItems];
            values = new double[numberOfItems];
            newPopulation = new bool[numberOfItems, populationSize];
            probabilityDiapason = new double[populationSize, 2];
            bestHis = new List<double>();
            for (int i = 0; i < numberOfItems; i++)
            {
                weights[i] = weightsTemplate[i];
                values[i] = valuesTemplate[i];
            }

            //Tao quan the 
            for (int i = 0; i < numberOfItems; i++)
            {
                for (int j = 0; j < populationSize; j++)
                {
                    if (rnd.NextDouble() > 0.5)
                        population[i, j] = true;
                    else
                        population[i, j] = false;
                }
            }

            //Hien thi quan the len data grid
            if (populationSize < 100)
            {
                dataGridView2.ColumnCount = numberOfItems;
                dataGridView2.RowCount = populationSize;
                int rowNumber = 0;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    row.HeaderCell.Value = "Chromosome " + (rowNumber + 1);
                    rowNumber = rowNumber + 1;
                }
                for (int i = 0; i < numberOfItems; i++)
                {
                    for (int j = 0; j < populationSize; j++)
                    {
                        if (!population[i, j])
                        { dataGridView2[i, j].Value = 0; }
                        else
                        { dataGridView2[i, j].Value = 1; }
                    }
                }
            }

            dataGridView1.ColumnCount = numberOfItems;
            dataGridView1.RowCount = 2;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {

                column.HeaderText = String.Concat("Item ",
                    (column.Index + 1).ToString());
            }
            dataGridView1.Rows[0].HeaderCell.Value = " Value";
            dataGridView1.Rows[1].HeaderCell.Value = "Weight";
            for (int i = 0; i < numberOfItems; i++)
            {
                dataGridView1[i, 0].Value = values[i];
                dataGridView1[i, 1].Value = weights[i];
            }

            //Tinh do thich nghi
            calculateFitness();
            label19.Text = "Chromosome " + (bestSolutionIndex + 1) + ", value: " + bestSolutionValue + ", weight: " + bestSolutionWeight + ", " + bestSolutionQuantity + " items taken.";
            label18.Text = "Chromosome " + (bestFitnessIndex + 1) + ", value: " + bestFitnessValue + ", weight: " + bestFitnessWeight + ", " + bestFitnessQuantity + " items taken.";
            currentGeneration++;
            bestHis.Add(bestSolutionValue);
        }              

        //Ham tinh do thich nghi
        void calculateFitness()
        {
            for (int i = 0; i < populationSize; i++)
            {
                fitness[i] = 0;
                sumOfWeights[i] = 0;
                quantityOfItems[i] = 0;
            }
            for (int i = 0; i < populationSize; i++)
            {
                for (int j = 0; j < numberOfItems; j++)
                {
                    if (population[j, i])
                    {
                        fitness[i] = fitness[i] + values[j];
                        sumOfWeights[i] = sumOfWeights[i] + weights[j];
                        quantityOfItems[i]++;
                    }
                }
            }
            bestFitnessValue = fitness.Max();
            bestFitnessIndex = fitness.ToList().IndexOf(bestFitnessValue);
            bestFitnessWeight = sumOfWeights[bestFitnessIndex];
            bestFitnessQuantity = quantityOfItems[bestFitnessIndex];
            bestSolutionValue = 0;
            for (int i = 0; i < populationSize; i++)
            {
                if (fitness[i] > bestSolutionValue && sumOfWeights[i] <= capacity)
                {
                    bestSolutionValue = fitness[i];
                    bestSolutionIndex = i;
                    bestSolutionWeight = sumOfWeights[i];
                    bestSolutionQuantity = quantityOfItems[i];
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label15.Text = (currentGeneration).ToString();
            for (int i = 0; i < numberOfItems; i++)
            {
                for (int j = 0; j < populationSize; j++)
                {
                    newPopulation[i, j] = false;
                }
            }
            currentChromosome = 0;

            //Elitism - sao chep nhiem sac the tot nhat vao the he tiep theo
            for (int i = 0; i < numberOfItems; i++)
            {
                newPopulation[i, currentChromosome] = population[i, bestSolutionIndex];
            }
            currentChromosome++;
            probabilityCalculation();
            while (currentChromosome < populationSize)
            {
                parentsSeletion();
                double breed = rnd.NextDouble();
                if (breed <= crossoverProbability)
                    crossover();
                else
                {
                    for (int i = 0; i < numberOfItems; i++)
                    {
                        newPopulation[i, currentChromosome] = population[i, parentIndex1];
                    }
                    currentChromosome++;
                    if (currentChromosome < populationSize)
                    {
                        for (int i = 0; i < numberOfItems; i++)
                        {
                            newPopulation[i, currentChromosome] = population[i, parentIndex2];
                        }
                        currentChromosome++;
                    }
                }
            }
            mutation();

            for (int i = 0; i < numberOfItems; i++)
            {
                for (int j = 0; j < populationSize; j++)
                {
                    population[i, j] = newPopulation[i, j];
                }
            }
            if (populationSize < 100)
            {
                for (int i = 0; i < numberOfItems; i++)
                {
                    for (int j = 0; j < populationSize; j++)
                    {
                        if (!population[i, j])
                        { dataGridView2[i, j].Value = 0; }
                        else
                        { dataGridView2[i, j].Value = 1; }
                    }
                }
            }

            calculateFitness();
            bestHis.Add(bestSolutionValue);
            label19.Text = "Chromosome " + (bestSolutionIndex + 1) + ", value: " + bestSolutionValue + ", weight: " + bestSolutionWeight + ", " + bestSolutionQuantity + " items taken.";
            label18.Text = "Chromosome " + (bestFitnessIndex + 1) + ", value: " + bestFitnessValue + ", weight: " + bestFitnessWeight + ", " + bestFitnessQuantity + " items taken.";

            currentGeneration++;
            if (currentGeneration > numberOfGenerations)
            {
                label20.Visible = Visible;
                label20.Text = "Final population:";
                button2.Visible = !Visible;
                button3.Visible = !Visible;              
            }
        }

        void probabilityCalculation()
        {
            for (int i = 0; i < populationSize; i++)
            {
                selectionProbability[i] = 0;
                for (int j = 0; j < 2; j++)
                {
                    probabilityDiapason[i, j] = 0;
                }
            }
            double sumFitness = 0;
            for (int i = 0; i < populationSize; i++)
            {
                if (sumOfWeights[i] <= capacity)
                    sumFitness = sumFitness + fitness[i];
            }
            for (int i = 0; i < populationSize; i++)
            {
                if (sumOfWeights[i] <= capacity)
                {
                    selectionProbability[i] = 100 * fitness[i] / sumFitness; //tinh phan tram cua ham thich nghi bang tong cac ham thich nghi
                }
                else
                    selectionProbability[i] = 0;
            }
            probabilityDiapason[0, 0] = 0;
            probabilityDiapason[0, 1] = selectionProbability[0];
            for (int i = 1; i < populationSize; i++)
            {
                probabilityDiapason[i, 0] = probabilityDiapason[i - 1, 1] + 1;
                probabilityDiapason[i, 1] = probabilityDiapason[i, 0] + selectionProbability[i];
            }
        }

        void parentsSeletion()
        {
            parentIndex1 = 0;
            parentIndex2 = 0;
            Random rnd = new Random();
            int roulette = rnd.Next(0, 100);
            for (int i = 1; i < populationSize; i++)
            {
                if (roulette >= probabilityDiapason[i, 0] && roulette < probabilityDiapason[i, 1])
                {
                    parentIndex1 = i;
                    break;
                }
            }
            roulette = 0;
            bool rouletteValid = false;
            while (!rouletteValid)
            {
                roulette = rnd.Next(0, 100);
                if (roulette < probabilityDiapason[parentIndex1, 0] || roulette >= probabilityDiapason[parentIndex1, 1])
                    rouletteValid = true;
            }
            for (int i = 1; i < populationSize; i++)
            {
                if (roulette >= probabilityDiapason[i, 0] && roulette < probabilityDiapason[i, 1])
                {
                    parentIndex2 = i;
                    break;
                }
            }
        }

        void crossover()
        {
            Random rnd = new Random();
            int division = rnd.Next(1, numberOfItems - 2);
            bool firstParent = new bool();
            if (rnd.NextDouble() > 0.5)
                firstParent = true;
            else
                firstParent = false;
            for (int i = 0; i < division; i++)
            {
                if (firstParent)
                    newPopulation[i, currentChromosome] = population[i, parentIndex1];
                else
                    newPopulation[i, currentChromosome] = population[i, parentIndex2];
            }
            for (int i = division; i < numberOfItems; i++)
            {
                if (!firstParent)
                    newPopulation[i, currentChromosome] = population[i, parentIndex1];
                else
                    newPopulation[i, currentChromosome] = population[i, parentIndex2];
            }
            currentChromosome++;
        }

        void mutation()
        {
            Random rnd = new Random();
            double mutate = new double();
            for (int i = 0; i < numberOfItems; i++)
            {
                for (int j = 0; j < populationSize; j++)
                {
                    mutate = rnd.NextDouble();
                    if (mutate <= mutationProbability)
                        newPopulation[i, j] = !newPopulation[i, j];
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            while (currentGeneration != numberOfGenerations + 1)
            {
                for (int i = 0; i < numberOfItems; i++)
                {
                    for (int j = 0; j < populationSize; j++)
                    {
                        newPopulation[i, j] = false;
                    }
                }
                currentChromosome = 0;
                Random rand = new Random();
                //Elitism - sao chep nhiem sac the tot nhat vao the he tiep theo
                for (int i = 0; i < numberOfItems; i++)
                {
                    newPopulation[i, currentChromosome] = population[i, bestSolutionIndex];
                }
                currentChromosome++;

                probabilityCalculation();

                Random rnd = new Random();
                while (currentChromosome < populationSize)
                {
                    parentsSeletion();
                    int breed = rnd.Next(0, 100);
                    if (breed <= crossoverProbability)
                        crossover();
                    else
                    {
                        for (int i = 0; i < numberOfItems; i++)
                        {
                            newPopulation[i, currentChromosome] = population[i, parentIndex1];
                        }
                        currentChromosome++;
                        if (currentChromosome < populationSize)
                        {
                            for (int i = 0; i < numberOfItems; i++)
                            {
                                newPopulation[i, currentChromosome] = population[i, parentIndex2];
                            }
                            currentChromosome++;
                        }
                    }
                }

                mutation();
                
                for (int i = 0; i < numberOfItems; i++)
                {
                    for (int j = 0; j < populationSize; j++)
                    {
                        population[i, j] = newPopulation[i, j];
                    }
                }

                calculateFitness();
                bestHis.Add(bestSolutionValue);
                currentGeneration++;
            }
            label15.Text = (currentGeneration - 1).ToString();
            if (populationSize < 100) 
            {
                label20.Text = "Final population:";
                for (int i = 0; i < numberOfItems; i++)
                {
                    for (int j = 0; j < populationSize; j++)
                    {
                        if (!population[i, j])
                        { dataGridView2[i, j].Value = 0; }
                        else
                        { dataGridView2[i, j].Value = 1; }
                    }
                }
            }
            label19.Text = "Chromosome " + (bestSolutionIndex + 1) + ", value: " + bestSolutionValue + ", weight: " + bestSolutionWeight + ", " + bestSolutionQuantity + " items taken.";
            label18.Text = "Chromosome " + (bestFitnessIndex + 1) + ", value: " + bestFitnessValue + ", weight: " + bestFitnessWeight + ", " + bestFitnessQuantity + " items taken.";
            button2.Visible = !button2.Visible;
            button3.Visible = !button3.Visible;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bestHis.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
        }
    }
}  


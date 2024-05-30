
using OCP;
using OCP.Abstractions;
using OCP.BonusCalculators;

IBonusCalculator secretaryBonusCalculator = new SecretaryBonusCalculator();
IBonusCalculator engineerBonusCalculator = new EngineerBonusCalculator();
IBonusCalculator headOfProductBonusCalculator = new HeadOfProductBonusCalculator();

Employee engineer = new Engineer("Mohammed BS",4500, engineerBonusCalculator);
Employee secretary = new Secretary("Alina Stiva", 2500, secretaryBonusCalculator, 7);
Employee headOfProduct = new HeadOfProduct("Andro Flinker", 5400, headOfProductBonusCalculator);

double engineerBonus = engineer.CalculateBonus();
double secretaryBonus = secretary.CalculateBonus();
double headOfProductBonus = headOfProduct.CalculateBonus();

Console.WriteLine("Engineer Bonus: {0:c2}", engineerBonus);
Console.WriteLine("Secretary Bonus: {0:c2}", secretaryBonus);
Console.WriteLine("Head of Product Bonus: {0:c2}",headOfProductBonus);
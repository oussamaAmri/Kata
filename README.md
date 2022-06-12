# Enveloppes rouges
Dans la culture chinoise, il est commun lors des célébrations de donner des "enveloppes rouges" (##) contenant un peu d'argent. Le plus souvent, les générations adultes donnent aux générations plus jeunes.

Vous souhaitez construire une application WeChat pour aider les grand-parents à répartir leur budget de don entre leurs petits-enfants. Écrivez un programme qui calcule le nombre de dons "porte-bohneur" (égaux à 8) en fonction du budget, money, et du nombre de petits-enfants, giftees.

Fonctionnement
De nombreuses règles, mêlant tradition et superstition, encadre ce don :
Les dons ne doivent pas contenir le montant 4 (#), car cela sonne comme "mort" (#). Il est de bonne augure de donner un montant de 8 (#), car cela sonne comme "fortune" (#). Il serait mal vu de ne rien donner à l'un des petits-enfants.

Votre algorithme doit donc retourner le nombre de dons égaux à 8 en respectant les règles suivantes :
Dépenser l'intégralité du budget (sauf s'il y a suffisamment de budget pour donner 8 à tout le monde)
Ne donner aucun 4 (par tradition, le budget ne sera jamais à 4). Ne donner aucun 0 (sauf si le budget n'est pas suffisant). Donner un maximum de 8 une fois les règles ci-dessus respectées

Implémentation
Implémentez la méthode LuckyMoney(money, giftees) qui :
prend en entrées les entiers money et giftees avec : 0 <= money < 100 0 < giftees < 10 et retourne le nombre de dons égaux à 8 sous forme d'un entier.

Exemples
Entrées
12
2
Sortie
0

Entrées
24
4
Sortie
2

Entrées
7
2
Sortie
0

# FindLargestKata
Algorithm.FindLargest(int[] numbers) should return the largest number from numbers. The array
numbers always contains at least one number.
Implement Algorithm.FindLargest(int[] numbers).

Time: 5 minutes

# ClosestToZeroKata
Implement ClosestToZero to return the integer in the array ints that is closest to zero. If there are two integers equally close to zero, consider the positive element to be closer to zero (example: if ints contains -5 and 5, return 5). If ints is null or empty, return 0 (zero).

Input: integers in ints have values ranging from -2147483647 to 2147483647.

Time: 15 minutes

# ATestKata
A.Test(int i, int j) should return true if one of the arguments equals 1 or if their sum is equal to 1.

For example:
A.Test(1, 5) returns true
A.Test(2, 3) returns false
A.Test(-3, 4) returns true

Time: 2 minutes

# StringParserKata
You are given a sequence of characters consisting of parentheses () and brackets []. A string of this type is said to be correct: if it is an empty or null string if the string A is correct, (A) and [B] are correct if the string A and B are correct, the concatenation AB is also correct
Input: The string contains at most 10 000 characters.

Examples: [()] is correct, (()[]) is correct, ([)] is not correct, (( is not correct.

Implement the method Check(String str) to check the correctness of a string of this type. Check returns true if the string is correct, false otherwise.

Time: 30 minutes

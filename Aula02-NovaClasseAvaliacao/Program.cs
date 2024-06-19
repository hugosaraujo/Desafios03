/*
    1- Modelar um Pet Shop com classes como Pet, Dono, Consulta e médico.

    2- Modelar o funcionamento de uma oficina automobilistica.

    3- Criar um programa Program.cs e simular o funcionamento do programa.

*/

using Aula02_NovaClasseAvaliacao.Oficina.Modelos;

Veiculo versa = new Veiculo("Versa", "Nissan", 2022);
Mecanico tecnico1 = new Mecanico("Douglas"); 
Cliente cliete = new Cliente("Hugo", versa);
Atendimento atendimento = new Atendimento(tecnico1, versa);
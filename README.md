##### Design Patterns (Padrões de Projeto)     
[![N|MFYIT](https://contrib.azurewebsites.net/mfyit_card.png)](http://mfyit.azurewebsites.net) 


# Padrão Template Method 

> Um Template Method auxilia na definição de um algoritmo com partes do mesmo definidos por métodos abstratos. As subclasses devem se responsabilizar por estas partes abstratas, deste algoritmo, que serão implementadas, possivelmente de várias formas, ou seja, cada subclasse irá implementar à sua necessidade e oferecer um comportamento concreto construindo todo o algoritmo.

> O Template Method fornece uma estrutura fixa, de um algoritmo, esta parte fixa deve estar presente na superclasse, sendo obrigatório uma classeAbstrata que possa conter um método concreto, pois em uma interface só é possível conter métodos abstratos que definem um comportamento, esta é a vantagem de ser uma Classe Abstrata porque também irá fornecer métodos abstratos às suas subclasses, que por sua vez herdam este método, por Herança (programação), e devem implementar os métodos abstratos fornecendo um comportamento concreto aos métodos que foram definidos como abstratos. Com isso certas partes do algoritmo serão preenchidos por implementações que irão variar, ou seja, implementar um algoritmo em um método, postergando a definição de alguns passos do algoritmo, para que outras classes possam redefiní-los.

### Estrutura

> A representação do diagrama de classe no modelo da UML mostra como acontece físicamente a herança e quem fica responsável pela implementação. A importância de um diagrama de classes é porque descreve os tipos de objetos presentes no sistema e os vários tipos de relacionamentos estáticos existentes entre eles.
![N|MFYIT](https://upload.wikimedia.org/wikipedia/commons/2/20/ClassDiagramTemplateMethod.png)

---

## Installation

- Download the latest .NET Core SDK

* [.NET Core 2.0 SDK](release-notes/download-archives/2.0.3.md)

### Clone

- Clone this repo to your local machine using `https://github.com/BrunoLopes/Xperiments.DesignPatterns.Interpreter`

### Setup



> Restore all the packages first

```shell
$ dotnet restore
```

> now build the project

```shell
$ dotnet build
```
---

## Support

Reach out to me at one of the following places!

- Website:  [![Awesome](https://cdn.rawgit.com/sindresorhus/awesome/d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)](http://mfyit.azurewebsites.net)
- Email: emfyit@gmail.com

---

## Donations (Optional)

[![Support via Gratipay](https://cdn.rawgit.com/gratipay/gratipay-badge/2.3.0/dist/gratipay.png)](https://liberapay.com/brunolopes/donate)


---

## License

[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)

- **[MIT license](http://opensource.org/licenses/mit-license.php)**
- Copyright MFY IT © 2017  

## NLayeredAppDemo
**Katmanlara ait Referanslar**
   
    DataAccessLayer ==> Entities
   
    BusinessLogicLayer ==> Entities, DataAccessLayer
   
    PresentationLayer(UI) ==> Entities, BusinessLogiclayer
   
**Yüklenen Paket-Frameworkler**
    
    DataAccessLayer ==> EntityFramework
   
    BusinessLogicLayer ==> EntityFramework, FluentValidation, Ninject
   
    PresentationLayer(UI) ==> EntityFramework, Ninject
   
**Kullanılan Prensip ve Desenler**

    - Repository Design Pattern
    
    - Fluent Validation
    
    - Dependency Inversion/Injection
    
    - IoC Container (Ninject)
  
   

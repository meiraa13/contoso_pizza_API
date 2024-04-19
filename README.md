# ContosoPizza
Api for a pizza shop with complete crud being able to create, find all pizzas, find one pizza, update and delete a pizza.

## Techs:
- C#
- .NET
  
## Endpoints:


| Method | Endpoint                   | Responsability                                  
| ------ | -------------------------- | ------------------------------------------------- |
| GET    | /pizza                     | get all pizzas                                    | 
| GET    | /pizza/id                  | get a specific pizza                              | 
| POST   | /pizza                     | create a pizza                                    |
| PUT    | /pizza/id/                 | update pizza info                                 |
| DELETE | /pizza/id/                 | delete a pizza                                    |

## Body request:
{
  "name":string,
  "IsGlutenFree":bool
}

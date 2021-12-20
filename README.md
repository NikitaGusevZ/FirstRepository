
## `Содержание`
[Введение](#введение)

1 [Описание предметной области](#по)

1.1 [Указание на проблематику](#проблематика) 

1.2 [Формулировка задачи](#формулировка_задачи)

2 [Существующие решения проблемы](#существующие_решения_проблемы)

3 [Тестирование](#разработка_системы)

3.1 [Проектирование системы](#проектирование)

3.2 [Реализация системы](#реализация)

4 [Тестирование](#тестирование)

[Список литературы](#список_литературы)

<br/><br/> 

<br/><br/>
  
  
<br/><br/> 


<br/><br/> 

<br/><br/>

<br/><br/>

<br/><br/>

<br/><br/> 




***

## Введение <a name ="введение"></a>
В связи с развитием информационных технологий сервисы онлайн-дистрибуции программного обеспечения становятся все более популярным и начинают играть важную роль в жизни человека. Они занимаются распространением цифрового контента (компьютерных игр, аудио, электронных книг, фильмов, графики и прочего программного обеспечения) без использования материального носителя, как правило, состоящий в загрузке через Интернет на конечное устройство пользователя. Преимущество цифровой дистрибуции заключается в лёгком и быстром поиске и приобретении копий необходимого программного обеспечения.

***

## 1 Описание предметной области <a name ="по"></a>
Цифровая дистрибуция или цифровое распространение — один из современных способов распространения легального электронного контента (музыка, видео, программное обеспечение, видеоигры). Этот термин обычно используется в тех случаях, когда распространение медиа-контента происходит по интернет-каналам, то есть без использования физических методов распространения информации — другими словами, без материальных носителей информации.[1] 

Распространять контент через Интернет позволяют специализированные сети, — так называемые сети доставки и дистрибуции содержимого (CDN)[2] — и делается это за счёт их высокой доступности и большой производительности.

Как правило, цифровая дистрибуция характеризуется такими преимуществами, как относительно лёгкий и быстрый поиск и приобретение копий того или иного нужного покупателю программного обеспечения.
Сервис онлайн-дистрибуции программного обеспечения обычно имеют форму интернет-магазина , где пользователи могут просматривать эти разные категории приложений, просматривать информацию о каждом приложении (например, обзоры или рейтинги) и приобретать приложение (включая покупку приложения, если необходимо - предлагается множество приложений. без каких-либо затрат). Выбранное приложение предлагается для автоматической загрузки, после чего оно устанавливается. Некоторые магазины приложений могут также включать в себя систему для автоматического удаления установленной программы с устройств при определенных условиях с целью защиты пользователя от вредоносного программного обеспечения. 

Сервис онлайн-дистрибуции программного обеспечения обычно предоставляют пользователям возможность оставлять отзывы и оценки. Эти обзоры полезны для других пользователей, разработчиков и владельцев магазинов приложений. Пользователи могут выбирать лучшие приложения на основе оценок, разработчики получают отзывы о том, какие функции хвалят или не любят, и, наконец, владельцы магазинов приложений могут обнаруживать плохие приложения и вредоносных разработчиков, автоматически анализируя отзывы с помощью методов интеллектуального анализа данных. 

Сервис онлайн-дистрибуции программного обеспечения курируют их владельцы, что требует, чтобы представленные перспективные приложения проходили процесс утверждения. Эти приложения проверяются на соответствие определенным правилам (например, по контролю качества и цензуре), включая требование о взимании комиссии за каждую продажу платного приложения. Некоторые сервисы онлайн-дистрибуции предоставляют разработчикам обратную связь: количество установок, проблемы на местах (задержка, сбой и т.д.). 

***

  ### 1.1 Указание на проблематику <a name ="проблематика"></a>
  Подавляющее количество людей покупает программное обеспечение через интернет, так как это быстрее и удобнее по сравнению с покупкой физического носителя информации и затем установки программного обеспечения через него. Также приемуществом является то, что покупатель может сразу установить купленное ПО на свое устройство, а также оставить отзыв, который смогут увидеть другие покупатели. Разработчики в свою очередь ищут такое место, где можно разместить свой продукт так, чтобы его могло увидеть как можно большее количество людей,получить за него максимальню прибыль и иметь обратную связь с системой для получения отчетов о результатах продаж. При создании данной информационной системы нужно учесть все это для удобства работы с ней как покупателю, так и разработчику.
***

  ### 1.2 Формулировка задачи <a name ="формулировка_задачи"></a>
  Для решения проблем создаётся информационная система онлайн-дистрибуции программного обеспечения ,задачи которой:
  - Облегчение поиска и покупки программного обеспечения
  - Облегчение размещения программного обеспечения для разработчиков
  - Обеспечение возможности оставлять отзыв покупателям
  - Обеспечение возможности разработчикам получать отчеты о результатах продаж их продуктов
    
***
## 2 Существующие решения проблемы <a name ="существующие_решения_проблемы"></a>

**Steam** — сервис цифрового распространения компьютерных игр и программ, который разработан корпорацией Valve. Steam предлагает пользователям возможность управления цифровыми правами, а также позволяет играть во многопользовательские игры. Steam позволяет пользователям устанавливать и автоматически обновлять игры на нескольких компьютерах, а особенностью этого сообщества являются наличие списка друзей и групп, возможность сохранения в "облаке" и общения в игре, функциональный чат, а также встроенный интернет-браузер.[2]

Steam считается самой крупной платформой цифровой дистрибуции компьютерных игр, которая, согласно исследованиям компании Screen Digest, уже в октябре 2013 года занимала 75% рыночного пространства. К концу 2015 года на сервисе было зарегистрировано более 125 миллионов аккаунтов, в число которых входили примерно 12,5 миллионов пользователей, одновременно находящихся в сети.[3]

После покупки игры она привязывается к аккаунту пользователя, доступ к которому может осуществляться одновременно только с одного компьютера. Стоит отметить, что даже некоторые распространяемые на дисках игры могут требовать обязательной регистрации в Steam, а также для этих игр, в том числе и одиночных, требуется подключение к интернету для их активации. Активация игр на дисках происходит после ввода указанного на коробке лицензионного ключа, после чего пользователь уже может запустить игровой процесс.

**Origin** — платформа цифровой дистрибуции компании Electronic Arts, которая даёт возможность пользователям приобретать компьютерные игры через Интернет и загружать их с помощью клиента Origin (ранее EA Download Manager, EA Downloader и EA Link). 3 июня 2011 EA Store был переименован в Origin. В 2011 году компания Electronic Arts заявила, что хотела бы, чтобы Origin соответствовал их главному конкуренту, сервису Steam, путём добавления облачных сохранений, автообновления игр, достижений и кроссплатформенных релизов. В Origin используются социальные функции, такие как управление профилем, общение с друзьями в чате и во время игры с помощью внутригрового приложения, интеграция с Facebook, Xbox Live и PlayStation Network. На данный момент имеется возможность автообновления игр, синхронизация сохранений игр в облачном хранилище, общение во встроенном чате. К 2013 году, в Origin было зарегистрировано более 50 миллионов пользователей.[4]

***
## 3 Разработка системы <a name ="разработка_системы"></a>
***
### 3.1 Проектирование системы <a name="проектирование"></a>
Разработка информационной системы начинается с построения USE-CASE диаграммы (Диаграмма вариантов использования) , которая состоит из участников и прецендетов.(см. рисунок 1)

Участник - это множество логически связанных ролей, исполняемых при взаимодействии с прецедентами или сущностями (система, подсистема или класс). Участником может быть человек или другая система, подсистема или класс, которые представляют нечто вне сущности. Графически участник изображается “человечком”.

Прецедент - описание множества последовательных событий (включая варианты), выполняемых системой, которые приводят к наблюдаемому участником результату. Прецедент представляет поведение сущности, описывая взаимодействие между участниками и системой. Прецедент не показывает, “как” достигается некоторый результат, а только “что” именно выполняется. Прецеденты обозначаются очень простым образом - в виде эллипса, внутри которого указано его название.[5]
<p align="center">
<img src = "https://user-images.githubusercontent.com/89989588/145208125-c811c839-9164-406b-8a92-f48644c53129.png"></p>
  <p align="center">Рисунок 1 - Диаграмма вариантов использования</p>  
На основе USE-CASE диаграммы разрабатвается DFD диаграмма, которая наглядно отображает течение информации в пределах системы.(см. рисунок 2)
<p align="center">
<img src = "https://user-images.githubusercontent.com/89989588/145209174-1f8eb17a-a37d-4f89-a0a1-053f9ce9d495.png"></p>
  <p align="center">Рисунок 2 - Диаграмма потоков данных</p>  
На основе DFD диаграммы проектируется схема «сущность-связь» (ER-диаграмма), где показано, как разные «сущности» (люди, объекты, концепции и так далее) связаны между собой внутри системы.(см. рисунок 3)
<p align="center">
<img src = "https://user-images.githubusercontent.com/89989588/145209359-81ad4f8e-eba6-463e-8e2a-a82dd78fcdf4.png"></p>
<p align="center">Рисунок 3 - Диаграмма «сущность-связь»</p> 

***
### 3.2 Реализация системы <a name="реализация"></a>
На основании ER-диаграммы создали классы. Примеры классов "Клиент" и "Программное обеспечение" представленны на листингах 1 и 2 соответственно.
Листинг 1 - Класс "Клиент"
```csharp
     public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

    }
```
Листинг 2 - Класс "Программное обеспечение"
```csharp
        public class Software
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int SoftwareTypeId { get; set; }
        public int Rating{ get; set; }
        public int DeveloperId { get; set; }
    }
```
Затем отпределили где они будут храниться, создав репозитории ......

Листинг 3 - Репрезиторий для класса "Клиент"
```csharp
        public class CustomerStorage
    {
        private readonly Dictionary<int, Customer > _customers  = new ();
 
        public void Create(Customer customer)
        {
            _customers.Add(customer.Id, customer);
        }

        public Customer Read(int customerId)
        {
            return _customers[customerId];
        }

        public Customer Update(int customerId, Customer newCustomer)
        {
            _customers[customerId] = newCustomer;
            return _customers[customerId];
        }

        public bool Delete(int customerId)
        {
            return _customers.Remove(customerId);
        }
    }
```
Листинг 4 - Общеее хранилище
```csharp
        public class Storage
    {
        public static readonly ShoppingBasketStorage ShoppingBasketStorage = new();
        public static readonly CustomerStorage CustomerStorage = new();
        public static readonly DeveloperStorage DeveloperStorage = new();
        public static readonly DistributorStorage DistributorStorage = new();
        public static readonly OrganizationStorage OrganizationStorage = new();
        public static readonly PaymentReportStorage PaymentReportStorage = new();
        public static readonly PaymentStorage PaymentStorage = new();
        public static readonly SoftwareStorage SoftwareStorage = new();
        public static readonly SoftwareTypeStorage SoftwareTypeStorage = new();
    }
```
Разработали набор web-методов, включая 4 базисные операции CRUD, для каждой сущности, отражающих предметную область. Примеры контроллеров для классов "Клиент" и "Платеж" представлены на листингах 5 и 6.

Листинг 5 - Контроллер для класса "Клиент"
```csharp
    [ApiController]
    [Route("/customer")]
    public class CustomerController : ControllerBase
    {

        [HttpGet("SearchPO")]
        public string SearchPO(string str)
        {
            return str;
        }

        [HttpGet("BuyPO")]
        public string BuyPO(string str)
        {
            return str;
        }


        [HttpGet("DownloadPO")]
        public string DownloadPO(string str)
        {
            return str;
        }


        [HttpGet("GradePO")]
        public string GradePO(string str)
        {
            return str;
        }

        [HttpPut]
        public Customer Create(Customer customer)
        {
            Storage.CustomerStorage.Create(customer);
            return Storage.CustomerStorage.Read(customer.Id);
        }

        [HttpGet]
        public Customer Read(int Id)
        {
            return Storage.CustomerStorage.Read(Id);
        }

        [HttpPatch]
        public Customer Update(int Id, Customer newCustomer)
        {
            return Storage.CustomerStorage.Update(Id,newCustomer);
        }

        [HttpDelete]
        public bool Delete(int Id)
        {
            return Storage.CustomerStorage.Delete(Id);
        }
    }
```
Листинг 6 - Контроллер для класса "Платеж"
```csharp
    [ApiController]
    [Route("/payment")]
    public class PaymentController : ControllerBase
    {

        [HttpPut("Create")]
        public Payment Create(Payment payment)
        {
            Storage.PaymentStorage.Create(payment);
            return Storage.PaymentStorage.Read(payment.Id);
        }

        [HttpGet("Read")]
        public Payment Read(int Id)
        {
            return Storage.PaymentStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public Payment Update(int Id, Payment newPayment )
        {
            return Storage.PaymentStorage.Update(Id,newPayment);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.PaymentStorage.Delete(Id);
        }
    }
```

***
## 4 Тестирование <a name="тестирование"></a>
После запуска программы открывается страница Swagger UI со списком сущностей и операций над ними (см. рисунок 4).
<p align="center">
  <img src = "https://user-images.githubusercontent.com/89989588/146686323-3633f33a-9d9f-4cc9-a90e-2b858b812250.png"</p>
<p align="center">Рисунок 4 - Cтраница Swagger UI</p> 

Проверка работы методов CRUD (Create - создание, Read - чтение, Update - обновление, Delete - удаление) в сущности Customer (см. рисунок 5).
<p align="center">
  <img src = "https://user-images.githubusercontent.com/89989588/146686653-943b4f7a-b913-4c69-a06e-53fc6657fbf0.png"</p>
<p align="center">Рисунок 5 -Проверка работы методов CRUD</p> 

1) Create позволяет добавлять новые строки в вашу таблицу (см. рисунок 6).
<p align="center">
  <img src = "https://user-images.githubusercontent.com/89989588/146686666-4100b18f-ad04-42bd-ae66-fa952bf6f4b3.png"</p>
<p align="center">Рисунок 6 - Окно метода создания</p> 

Ввод необходимых данных об покупателе в соответствующие поля (см. рисунок 7).
<p align="center">
  <img src = "https://user-images.githubusercontent.com/89989588/146686677-8b9ad630-ea51-4299-9e22-52e1d79c1379.png"</p>
  <p align="center">Рисунок 7 - Работа с методом создания</p> 
  
После успешного выполнения операции сервер выдаёт ответ (см. рисунок 8).
<p align="center">
  <img src = "https://user-images.githubusercontent.com/89989588/146686685-cd43eb5f-342b-46b3-b6cd-703ae804d374.png"</p>
  <p align="center">Рисунок 8 - Результат выполнения операции создания</p> 
  
2) Функция чтения Read похожа на функцию поиска, поскольку позволяет извлекать определенные записи и считывать их значения (см. рисунок 9).
<p align="center">
  <img src = "https://user-images.githubusercontent.com/89989588/146686722-23c24399-92a0-4968-97d2-a30cb7a1760a.png"</p>
  <p align="center">Рисунок 9 - Окно функции чтения</p> 
  
Считывание информации об уже созданном покупателе по его Id (см. рисунок 10).
<p align="center">
  <img src = "https://user-images.githubusercontent.com/89989588/146686733-033441b0-244d-4b7c-9d0e-210d8254d405.png"</p>
  <p align="center">Рисунок 10 - Работа с методом чтения</p> 
  
После выполнения операции сервер выдаёт информацию об покупателе, которая была создана в Create (см. рисунок 11).
<p align="center">
  <img src = "https://user-images.githubusercontent.com/89989588/146686734-e26751e6-54a2-4386-b7e9-4bd07f8158a8.png"</p>
  <p align="center">Рисунок 11 - Результат выполнения операции чтения</p> 
  
3) Update, редактирование записи (см. рисунок 12). Используется для изменения существующих записей в базе данных.
<p align="center">
  <img src = "https://user-images.githubusercontent.com/89989588/146686764-1a03eeb7-e80e-4373-89c5-b330bb74135d.png"</p>
  <p align="center">Рисунок 12 - Окно метода обновления</p> 
  
Изменение информации об покупателе, для этого сначала нужно ввести его номер и затем новые данные (см. рисунок 13).
<p align="center">
  <img src = "https://user-images.githubusercontent.com/89989588/146686772-e39ac9c5-4b4c-44b9-b017-99d44cbc586c.png"</p>
  <p align="center">Рисунок 13 - Работа с методом обновления</p> 
  
После выполнения операции сервер выдаёт новую информацию о том же покупателе (см. рисунок 14).
<p align="center">
  <img src = "https://user-images.githubusercontent.com/89989588/146686783-ff1b6374-1c00-4b28-b5c9-09f83c1c8b63.png"</p>
  <p align="center">Рисунок 14 - Результат выполнения операции обновления</p> 
  
Функцией read проверка вышеуказанной операции. После срабатывания сервер выдает новую информацию об авторе (см. рисунок 15).
<p align="center">
  <img src = "https://user-images.githubusercontent.com/89989588/146686987-558709dd-3d33-4a59-9516-ff0a4b9e9e70.png"</p>
  <p align="center">Рисунок 15 - Результат выполнения операции чтения после обновления данных</p> 
  
4) Delete - используется для удаления записи по Id. Если операция удаления сработает успешно, то ответ сервера будет "true", иначе "false" (см. рисунок 16).
<p align="center">
  <img src = "https://user-images.githubusercontent.com/89989588/146686993-59f50266-f8dc-409e-8662-9cc5ef15dced.png"</p>
  <p align="center">Рисунок 16 - Окно метода удаления</p> 
  
Удаление покупателя по его Id (см. рисунок 17).
<p align="center">
  <img src = "https://user-images.githubusercontent.com/89989588/146687000-4bfff603-7954-4653-ae79-a5e46187487f.png"</p>
  <p align="center">Рисунок 17 - Работа с методом удаления</p> 
  
После выполнения операции ответ сервера (см. рисунок 18).
<p align="center">
  <img src = "https://user-images.githubusercontent.com/89989588/146687008-6dfe6982-dfe6-4937-81d9-dc10392ecae3.png"</p>
  <p align="center">Рисунок 18 - Раезультат выполнения метода удаления</p> 
  
Проверка вышеописанного действия с помощью read, считывание информацию об удалённом покупателе (см. рисунок 19).
<p align="center">
  <img src = "https://user-images.githubusercontent.com/89989588/146687029-c41f8514-9cca-490d-8b1e-aa21f014736f.png"</p>
  <p align="center">Рисунок 19 - Работа с операцией чтения</p> 
  
После срабатывания программа не выдаёт информации об этом покупателе (см. рисунок 20).
<p align="center">
  <img src = "https://user-images.githubusercontent.com/89989588/146687915-d9761104-29ae-47de-8824-312c1612e734.png"</p>
  <p align="center">Рисунок 20 - Результат выполнения операции чтения после удаления данных</p>
  
  <br/><br/> 
  
***
## Заключение

В рамках данной работы была разработана информационная система сервиса онлайн-дистрибуции программного обеспечения. Для этого сначала были определены внешние системы, влияющие на решение, а также системы, учитываемые при формировании допустимых решений; цели, требования, условия, затем была проведена проверка полноты и достоверности исходных данных, и наконец, были оценены реальные последствия. В перспективе предполагается привязаться проект к базе данных, добавить методы для увеличения спектра возможностей работы на сайте.

***
## Cписок используемых источников <a name="список_литературы"></a>

[1] - ComputerHope: Digital distribution [Электронный ресурс] Режим доступа:https://www.computerhope.com/jargon/d/digital-distribution.htm, свободный (дата обращения: 08.12.2021).

[2] -  Что такое CDN и как это работает?[Электронный ресурс] Режим доступа:https://habr.com/ru/company/selectel/blog/463915/, свободный (дата обращения: 15.12.2021).

[3] - Steam: About [Электронный ресурс] Режим доступа:https://store.steampowered.com/about/, свободный (дата обращения: 08.12.2021).

[4] - Steam Reaches New Concurrent User Record [Электронный ресурс] Режим доступа:http://www.gamespot.com/articles/steam-reaches-new-concurrent-user-record/1100-6431895/, свободный (дата обращения: 08.12.2021).

[5] - Origin: About [Электронный ресурс] Режим доступа:https://www.origin.com/rus/ru-ru/store/about, свободный (дата обращения: 08.12.2021).

[6] - UML Use Case Diagram Tutorial [Электронный ресурс] Режим доступа:https://www.lucidchart.com/pages/uml-use-case-diagram, свободный (дата обращения: 08.12.2021).

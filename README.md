# Сервис онлайн-дистрибуции программного обеспечения
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

***
## Введение <a name ="введение"></a>
В связи с развитием информационных технологий сервисы онлайн-дистрибуции программного обеспечения становятся все более популярным и начинают играть важную роль в жизни человека. Они занимаются распространением цифрового контента (компьютерных игр, аудио, электронных книг, фильмов, графики и прочего программного обеспечения) без использования материального носителя, как правило, состоящий в загрузке через Интернет на конечное устройство пользователя. Преимущество цифровой дистрибуции заключается в лёгком и быстром поиске и приобретении копий необходимого программного обеспечения.
***
## 1 Описание предметной области <a name ="по"></a>
Цифровая дистрибуция или цифровое распространение — один из современных способов распространения легального электронного контента (музыка, видео, программное обеспечение, видеоигры). Этот термин обычно используется в тех случаях, когда распространение медиа-контента происходит по интернет-каналам, то есть без использования физических методов распространения информации — другими словами, без материальных носителей информации. 

Распространять контент через Интернет позволяют специализированные сети, — так называемые сети доставки и дистрибуции содержимого (CDN) — и делается это за счёт их высокой доступности и большой производительности.

Как правило, цифровая дистрибуция характеризуется такими преимуществами, как относительно лёгкий и быстрый поиск и приобретение копий того или иного нужного покупателю программного обеспечения.
Сервис онлайн-дистрибуции программного обеспечения обычно имеют форму интернет-магазина , где пользователи могут просматривать эти разные категории приложений, просматривать информацию о каждом приложении (например, обзоры или рейтинги) и приобретать приложение (включая покупку приложения, если необходимо - предлагается множество приложений. без каких-либо затрат). Выбранное приложение предлагается для автоматической загрузки, после чего оно устанавливается. Некоторые магазины приложений могут также включать в себя систему для автоматического удаления установленной программы с устройств при определенных условиях с целью защиты пользователя от вредоносного программного обеспечения. 

Сервис онлайн-дистрибуции программного обеспечения обычно предоставляют пользователям возможность оставлять отзывы и оценки. Эти обзоры полезны для других пользователей, разработчиков и владельцев магазинов приложений. Пользователи могут выбирать лучшие приложения на основе оценок, разработчики получают отзывы о том, какие функции хвалят или не любят, и, наконец, владельцы магазинов приложений могут обнаруживать плохие приложения и вредоносных разработчиков, автоматически анализируя отзывы с помощью методов интеллектуального анализа данных. 

Сервис онлайн-дистрибуции программного обеспечения курируют их владельцы, что требует, чтобы представленные перспективные приложения проходили процесс утверждения. Эти приложения проверяются на соответствие определенным правилам (например, по контролю качества и цензуре), включая требование о взимании комиссии за каждую продажу платного приложения. Некоторые сервисы онлайн-дистрибуции предоставляют разработчикам обратную связь: количество установок, проблемы на местах (задержка, сбой и т.д.). 

***
  ### 1.1 Указание на проблематику <a name ="указание_на_проблематику"></a>
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

**Steam** — сервис цифрового распространения компьютерных игр и программ, который разработан корпорацией Valve. Steam предлагает пользователям возможность управления цифровыми правами, а также позволяет играть во многопользовательские игры. Steam позволяет пользователям устанавливать и автоматически обновлять игры на нескольких компьютерах, а особенностью этого сообщества являются наличие списка друзей и групп, возможность сохранения в "облаке" и общения в игре, функциональный чат, а также встроенный интернет-браузер.

Steam считается самой крупной платформой цифровой дистрибуции компьютерных игр, которая, согласно исследованиям компании Screen Digest, уже в октябре 2013 года занимала 75% рыночного пространства. К концу 2015 года на сервисе было зарегистрировано более 125 миллионов аккаунтов, в число которых входили примерно 12,5 миллионов пользователей, одновременно находящихся в сети[Источник 4].

После покупки игры она привязывается к аккаунту пользователя, доступ к которому может осуществляться одновременно только с одного компьютера. Стоит отметить, что даже некоторые распространяемые на дисках игры могут требовать обязательной регистрации в Steam, а также для этих игр, в том числе и одиночных, требуется подключение к интернету для их активации. Активация игр на дисках происходит после ввода указанного на коробке лицензионного ключа, после чего пользователь уже может запустить игровой процесс.

**Origin** — платформа цифровой дистрибуции компании Electronic Arts, которая даёт возможность пользователям приобретать компьютерные игры через Интернет и загружать их с помощью клиента Origin (ранее EA Download Manager, EA Downloader и EA Link). 3 июня 2011 EA Store был переименован в Origin. В 2011 году компания Electronic Arts заявила, что хотела бы, чтобы Origin соответствовал их главному конкуренту, сервису Steam, путём добавления облачных сохранений, автообновления игр, достижений и кроссплатформенных релизов. В Origin используются социальные функции, такие как управление профилем, общение с друзьями в чате и во время игры с помощью внутригрового приложения, интеграция с Facebook, Xbox Live и PlayStation Network. На данный момент имеется возможность автообновления игр, синхронизация сохранений игр в облачном хранилище, общение во встроенном чате. К 2013 году, в Origin было зарегистрировано более 50 миллионов пользователей.

***
## 3 Разработка системы <a name ="разработка_системы"></a>
Разработка информационной системы начинается с построения USE-CASE диаграммы (Диаграмма вариантов использования) , которая состоит из участников и прецендетов.

Участник - это множество логически связанных ролей, исполняемых при взаимодействии с прецедентами или сущностями (система, подсистема или класс). Участником может быть человек или другая система, подсистема или класс, которые представляют нечто вне сущности. Графически участник изображается “человечком”.

Прецедент - описание множества последовательных событий (включая варианты), выполняемых системой, которые приводят к наблюдаемому участником результату. Прецедент представляет поведение сущности, описывая взаимодействие между участниками и системой. Прецедент не показывает, “как” достигается некоторый результат, а только “что” именно выполняется. Прецеденты обозначаются очень простым образом - в виде эллипса, внутри которого указано его название.
![USE_CASE](https://user-images.githubusercontent.com/89989588/145208125-c811c839-9164-406b-8a92-f48644c53129.png)

На основе USE-CASE диаграммы разрабатвается DFD диаграмма, которая наглядно отображает течение информации в пределах системы.
![DFD](https://user-images.githubusercontent.com/89989588/145209174-1f8eb17a-a37d-4f89-a0a1-053f9ce9d495.png)
На основе DFD диаграммы проектируется схема «сущность-связь» (ER-диаграмма), где показано, как разные «сущности» (люди, объекты, концепции и так далее) связаны между собой внутри системы.
![ER](https://user-images.githubusercontent.com/89989588/145209359-81ad4f8e-eba6-463e-8e2a-a82dd78fcdf4.png)

***
### 3.1 Проектирование системы <a name="проектирование"></a>
***
### 3.2 Реализация системы <a name="реализация"></a>
***
## 4 Тестирование <a name="тестирование"></a>
***
## Заключение
## Cписок используемых источников <a name="список_литературы"></a>

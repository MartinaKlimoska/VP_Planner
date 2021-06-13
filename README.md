# Проектна задача - Визуелно програмирање
## Тема: Планер

## 1. Опис на Апликација
Планер App
Апликацијата овозможува додавање/чување на Задачи (Tasks) и Настани (Events), нивно уредување/бришење, и различни прикази (View) на информациите.
## 2. Опис на Решение
### Податоци на апликацијата
Апликацијата чува два типа на податоци, Настани (Events) и Задачи (Tasks).
Настаните и задачите се чуваат во инстанца од класа Workspace, во следната структура
```
namespace Planner
{
    [Serializable]
    public class Workspace
    {
        private List<Task> tasks;
        private List<Task> completedTasks;
        private Dictionary<DateTime, List<Event>> events;
        
        public Workspace()
        {
            tasks = new List<Task>();
            completedTasks = new List<Task>();
            events = new Dictionary<DateTime, List<Event>>();
        }
...
```
Класата Workspace содржи две листи од задачи (за завршени и незавршени), и мапа/речник од лиса на настани групирани по денови/дати. 
Класата Workspace се серијализира и десеријализира при затворање и отворање на апликацијата.
### Kласен дијаграм

За визуелно прикажување на настаните/задачите користени се 'custom controls' TaskControl и EventControl, наследени од UserControl класата.
Пример: TaskControl
```
public partial class TaskControl : UserControl
    {
        public Form1 form { get; set; }
        public Task Task { get; set; }
        public TaskControl(Task t, Form1 f)
        {
            InitializeComponent();
```
### Изглед на прозорецот
Прозорецот на апликацијата е составен од два главни панели.
панел за приказ(view) на настани и задачи. Овој панел се менува во зависност од кој приказ е моментално избран.
Содржи лабели, копчиња и два панели во кои се прикажуваат настаните или задачите.
menupanel панел за мени, каде се избира приказ за податоците(tasks, events) и дополнително се прикажува дата и час.
### Менување на приказ
Типот на приказ е зачуван како currentView во Form.
Приказот се менува преку 2 функции setView() и display() кои се повикуваат по кликање на копчињата од menupanel.
display() функцијата се повикува по промена/бришење/додавање на настани/задачи, промена на ден и промена на приказ.
Оваа функција ги прикажува соодветните настани/задачи во соодветен панел, користејќи ги функциите DisplayTasks, DisplayEvents(овие функции динамички ги додаваат контролите).
setView() се повикува при промена на приказ и ги уредува лабелите и копчињата.
```c#
        public void display()
        {
            if (currentView == ViewType.DailyView)
            {
                DisplayTasks(Workspace.getTasks(), rightPanel);
                DisplayEvents(Workspace.getDailyEvents(), leftPanel);
            }
            if (currentView == ViewType.AllTasks)
...
        private void setView()
        {
            if (currentView == ViewType.DailyView)
            {
                leftLabel.Text = "Events";
                rightLabel.Text = "Tasks";
                button5.Visible = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button6.Visible = true;
            }
            if (currentView == ViewType.AllTasks)
...
```
## 3. Кратко упатство и Screenshots
Планерот има 3 типови на прикази(view): Daily View, All Tasks, All Events, од кои стандард е Daily View, каде се прикажуваат дневните настани и незавршени задачи.
All Tasks ги прикажува завршените и незавршените задачи, а All Events прикажува идни и веќе завршени задачи.
Додавањето на задачи и настани се врши со кликање на копчињата "Add new Event" или "Add new Task", и пополнување на дадената форма.
Задачите и настаните се сортираат и прикажуваат зависно од селектираниот приказ. Корисникот може да ги изменува, брише (и означи како завршени (задачи)) настаните и задачите.



Слики (images/icons) за апликацијата се избрани од www.stockio.com и www.canva.com

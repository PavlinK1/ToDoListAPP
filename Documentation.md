
# Документация

## Основни компоненти

### 1. Инициализация на формата
```csharp
public Form1()
{
    InitializeComponent();

    clbTasks.ItemCheck += clbTasks_ItemCheck;

    txtTask.Text = "Въведете нова задача...";
    txtTask.ForeColor = Color.Gray;
}
```
- **`InitializeComponent()`**: Зарежда компонентите на формата.
- **`clbTasks.ItemCheck`**: Регистрира събитие за промяна на състоянието на задачата.
- **Placeholder текст**: Настройва текст и цвят за текстовото поле.

---

### 2. Добавяне на задача
```csharp
private void btnAdd_Click(object sender, EventArgs e)
```
- Проверява дали текстът в `txtTask` не е празен.
- Премахва интервали чрез `Trim()`.
- Проверява за дублиращи се задачи.
- Добавя задача със символ `✘` за "незавършена" задача.

---

### 3. Маркиране на задача като завършена
```csharp
private void clbTasks_ItemCheck(object sender, ItemCheckEventArgs e)
```
- **Цел**: Променя символа `✘` на `✔` и обратно при маркиране.
- Използва `BeginInvoke`, за да се синхронизира с обновяването.

---

### 4. Премахване на задачи
```csharp
private void btnRemove_Click(object sender, EventArgs e)
```
- Премахва всички маркирани задачи от списъка.
- Показва съобщение, ако няма избрани задачи.

---

### 5. Запазване на списъка
```csharp
private void запазиToolStripMenuItem_Click(object sender, EventArgs e)
```
- **SaveFileDialog**: Позволява избор на файл за запазване.
- Генерира име на файл с текущата дата.
- Записва всички задачи във файла, включително състоянието им.

---

### 6. Зареждане на списъка
```csharp
private void отвориToolStripMenuItem_Click(object sender, EventArgs e)
```
- **OpenFileDialog**: Позволява избор на файл.
- Зарежда задачи от файла, запазвайки състоянието им (✔ или ✘).

---

### 7. Редактиране на задача
```csharp
private void btnEdit_Click(object sender, EventArgs e)
```
- Прехвърля избраната задача от списъка в текстовото поле за редактиране.

---

### 8. Placeholder текст
```csharp
private void txtTask_Enter(object sender, EventArgs e)
private void txtTask_Leave(object sender, EventArgs e)
```
- **При фокусиране**: Изчиства текста, ако е "Въведете нова задача...".
- **При загуба на фокус**: Връща текста "Въведете нова задача...", ако полето е празно.

---

## Основни класове и обекти

1. **`clbTasks`**: CheckedListBox за управление на списъка със задачи.
2. **`txtTask`**: Текстово поле за добавяне или редактиране на задачи.
3. **`btnAdd`, `btnRemove`, `btnEdit`**: Бутони за добавяне, изтриване и редактиране.
4. **Файл**: Опции за запазване и зареждане на списъка.

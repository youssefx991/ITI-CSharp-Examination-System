# ITI C# Examination System

A comprehensive console-based examination system built with C# that supports multiple question types, two exam modes, and includes an event-driven student notification system.

## 📋 Features

- **Multiple Question Types**
  - Choose One Question (Multiple Choice)
  - Choose All Question (Multiple Answer)
  - True/False Question

- **Two Exam Modes**
  - **Practice Exam**: Shows correct answers after completion
  - **Final Exam**: Only displays student answers without revealing correct ones

- **Event-Driven Architecture**
  - Student notification system using C# events
  - Exam started event triggers notifications to all enrolled students

- **Persistent Storage**
  - Questions stored in text files (`Practice_Questions.txt`, `Final_Questions.txt`)
  - Results saved to `Results.txt`

- **Repository Pattern**
  - Generic repository implementation for exam management

## 🏗️ Project Structure

```
Day7/
├── Answer.cs                  # Answer model
├── AnswerList.cs              # Collection of answers
├── ChooseAllQuestion.cs       # Multiple answer question type
├── ChooseOneQuestion.cs       # Single answer question type
├── TrueFalseQuestion.cs       # True/False question type
├── Question.cs                # Abstract base class for questions
├── QuestionList.cs            # Collection of questions
├── Exam.cs                    # Abstract base class for exams
├── PracticeExam.cs            # Practice exam implementation
├── FinalExam.cs               # Final exam implementation
├── ExamEventArgs.cs           # Event arguments for exam events
├── ExamMode.cs                # Enum for exam modes
├── Student.cs                 # Student model
├── Subject.cs                 # Subject model with student enrollment
├── Repository.cs              # Generic repository pattern
└── Program.cs                 # Entry point
```

## 🚀 Getting Started

### Prerequisites

- .NET 10.0 SDK or later
- Visual Studio 2022 or any C# compatible IDE

### Running the Application

1. Clone the repository:
```bash
git clone https://github.com/youssefx991/ITI-C--Examination-System.git
cd Day7
```

2. Build the project:
```bash
dotnet build
```

3. Run the application:
```bash
dotnet run
```

## 💻 Usage

1. When the application starts, you'll see a menu to select the exam type:
   - Enter `1` for Practice Exam
   - Enter `2` for Final Exam

2. The system will notify all enrolled students that the exam has started

3. Answer each question as prompted

4. **Practice Exam Results**: 
   - Displays your answer alongside the correct answer
   - Shows your total score

5. **Final Exam Results**:
   - Only displays your submitted answers
   - Does not reveal correct answers

## 📚 Core Classes

### Question Hierarchy
- **Question** (Abstract): Base class with common properties (Header, Body, Marks, Answers, CorrectAnswer)
  - **ChooseOneQuestion**: Single correct answer
  - **ChooseAllQuestion**: Multiple correct answers
  - **TrueFalseQuestion**: True/False questions

### Exam Hierarchy
- **Exam** (Abstract): Base class with exam logic and event handling
  - **PracticeExam**: Shows correct answers after completion
  - **FinalExam**: Hides correct answers

### Supporting Classes
- **Subject**: Manages enrolled students and handles exam notifications
- **Student**: Represents a student with notification capability
- **Repository<T>**: Generic repository for storing and retrieving exams
- **Answer & AnswerList**: Models for managing answers
- **QuestionList**: Manages collections of questions with file persistence

## 🔧 Key Concepts Demonstrated

- **Object-Oriented Programming**
  - Inheritance and polymorphism
  - Abstract classes and methods
  - Encapsulation

- **Event-Driven Programming**
  - Custom events and delegates
  - Event handlers

- **Design Patterns**
  - Repository Pattern
  - Template Method Pattern (via abstract classes)

- **C# Features**
  - Properties
  - Collections (List, Dictionary, HashSet)
  - File I/O operations
  - Exception handling
  - Collection expressions (C# 12)

## 📝 Sample Questions

The system includes sample mathematics questions:
- Arithmetic calculations
- Square roots
- Geometry
- Prime numbers
- Factors
- Algebra
- Constants

## 📄 Output Files

- **Practice_Questions.txt**: Stores practice exam questions
- **Final_Questions.txt**: Stores final exam questions
- **Results.txt**: Stores exam results

## 👥 Author

**Youssef** - [youssefx991](https://github.com/youssefx991)

## 📅 Project Information

- **Course**: ITI C# Programming
- **Day**: 7
- **Repository**: [ITI-C--Examination-System](https://github.com/youssefx991/ITI-C--Examination-System)

## 🎯 Future Enhancements

- Add database support for questions and results
- Implement user authentication
- Add time limit enforcement
- Generate detailed performance reports
- Support for question randomization
- Web-based interface
- Multiple subjects support

## 📖 License

This project is part of ITI coursework and is intended for educational purposes.

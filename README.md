# 📰 Blogging Platform Microservices with .NET & Docker

This project demonstrates a simple microservices architecture using .NET Web API and Docker. It consists of two microservices: **PostService** and **CommentService**.

---

## 🧱 Project Structure

```
/BlogPlatform
│
├── PostService/             # Microservice to manage blog posts
├── CommentService/          # Microservice to manage comments
├── Shared/                  # Shared DTOs between services
├── docker-compose.yml       # Docker Compose to orchestrate services
└── README.md
```

---

## 🔧 Services Overview

### 📫 PostService
- Responsible for creating and retrieving blog posts.
- **Endpoints**:
  - `POST /posts`: Create a new blog post
  - `GET /posts`: Get all blog posts

### 💬 CommentService
- Responsible for adding and retrieving comments linked to blog posts.
- Validates the `postId` by calling PostService before saving.
- **Endpoints**:
  - `POST /comments`: Add a comment to a post
  - `GET /comments/{postId}`: Get all comments for a specific post

---

## 🚀 Getting Started

### 🛠️ Build & Run with Docker

```bash
docker-compose up --build
```

- **PostService**: [http://localhost:6001](http://localhost:6001)
- **CommentService**: [http://localhost:6002](http://localhost:6002)

---


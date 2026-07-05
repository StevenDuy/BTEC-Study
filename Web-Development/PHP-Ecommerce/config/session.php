<?php
session_start();

function isLoggedIn() {
    return isset($_SESSION['user_id']);
}

function requireLogin() {
    if (!isLoggedIn()) {
        header('Location: /auth/login.php');
        exit();
    }
}

function requireRole($role) {
    if (!isLoggedIn() || $_SESSION['role'] !== $role) {
        header('Location: /index.php');
        exit();
    }
}

function getUserId() {
    return $_SESSION['user_id'] ?? null;
}

function getUserRole() {
    return $_SESSION['role'] ?? null;
}

function getUserName() {
    return $_SESSION['user_name'] ?? null;
}

function redirectByRole() {
    if (!isLoggedIn()) {
        header('Location: /auth/login.php');
        exit();
    }

    switch ($_SESSION['role']) {
        case 'admin':
            header('Location: /admin/index.php');
            break;
        case 'seller':
            header('Location: /seller/index.php');
            break;
        case 'user':
            header('Location: /user/index.php');
            break;
        default:
            header('Location: /auth/login.php');
    }
    exit();
}

function logout() {
    session_destroy();
    header('Location: /user/index.php');
    exit();
}
?>
<?php
require_once 'config/database.php';
require_once 'config/session.php';
require_once 'config/utils.php';

// Check if user is logged in and redirect based on role
if (isLoggedIn()) {
    redirectByRole();
} else {
    // Redirect to user home page for guest browsing
    header('Location: /user/index.php');
    exit();
}
?>
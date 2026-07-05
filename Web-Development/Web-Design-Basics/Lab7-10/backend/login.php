<?php
header('Content-Type: application/json');

require_once '../config/database.php';
$username = $_POST['username'] ?? '';
$password = $_POST['password'] ?? '';

if(!$username || !$password) {
    echo json_encode(['success' => false, 'message' => 'Vui lòng nhập đầy đủ thông tin.']);
    exit;
}
$stmt = $pdo->prepare('SELECT * FROM test WHERE username = ?');
$stmt->execute([$username]);
$user = $stmt->fetch();

if(is_array($user) && md5($password) == $user['password']) {
    echo json_encode(['success' => true, 'message' => 'Đăng nhập thành công.']);
} else {
    echo json_encode(['success' => false, 'message' => 'Tên đăng nhập hoặc mật khẩu không đúng.']);
}
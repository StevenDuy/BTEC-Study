function submitLoginForm() {
    const username = $('#LoginUsername').val();
    const password = $('#LoginPassword').val();

    if (username === '' || password === '') {
        Swal.fire({
            title: 'Lỗi',
            text: 'Vui lòng nhập đầy đủ thông tin.',
            icon: 'error',
            confirmButtonText: 'OK'
        });
        return false;
    }

    $.ajax({
        url: 'backend/login.php',
        method: 'POST',
        data: {
            username: username,
            password: password
        },
        success: function(response) {
            if (response.success == true) {
                Swal.fire({
                    title: 'Thành công',
                    text: 'Đăng nhập thành công.',
                    icon: 'success',
                    confirmButtonText: 'OK'
                }).then(() => {
                    window.location.href = 'index.php';
                });
            } else {
                Swal.fire({
                    title: 'Lỗi',
                    text: response.message,
                    icon: 'error',
                    confirmButtonText: 'OK'
                });
            }
        },
        error: function() {
            Swal.fire({
                title: 'Lỗi',
                text: 'Không thể kết nối máy chủ.',
                icon: 'error',
                confirmButtonText: 'OK'
            });
        }
    });
}
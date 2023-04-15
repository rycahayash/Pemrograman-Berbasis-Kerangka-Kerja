<?php
defined('BASEPATH') OR exit('No direct script access allowed');
?><!DOCTYPE html>
<html lang="en">
<head>
	<title>Home</title>
	<!-- Bootstrap CSS -->
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
	
	<!-- Custom CSS -->
	<style>
		.footer {
			position: absolute;
			bottom: 0;
			width: 100%;
			height: 60px; /*tinggi footer*/
		}
		.navbar-custom, .footer {
			background-color: #2A2F4F;
			color: white;
		}
		.jumbotron{
			background-color: #E3DFFD;
			color: black;
		}
	</style>
</head>
<body>
	<!-- Navigation bar -->
	<nav class="navbar navbar-expand-lg navbar-dark navbar-custom">
		<a class="navbar-brand" href="http://localhost/beritacoding/index.php">Rycahaya</a>
		<button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
			<span class="navbar-toggler-icon"></span>
		</button>
		<div class="collapse navbar-collapse" id="navbarNav">
			<ul class="navbar-nav">
				<li class="nav-item active">
					<a class="nav-link" href="http://localhost/beritacoding/index.php">Home</a>
				</li>
				<li class="nav-item">
					<a class="nav-link" href="http://localhost/beritacoding/index.php/about">About</a>
				</li>
				<li class="nav-item">
					<a class="nav-link" href="http://localhost/beritacoding/index.php/contact">Contact</a>
				</li>
			</ul>
		</div>
	</nav>

	<!-- Jumbotron -->
	<div class="jumbotron text-center">
		<h1>Welcome to CodeIgniter MVC!</h1>
		<p class="lead">CodeIgniter is a powerful PHP framework that helps developers build robust web applications with ease.</p>
	</div>

	<!-- Main content area -->
	<div class="container">
		<div class="row">
			<div class="col-md-8">
				<h2>What is CodeIgniter MVC?</h2>
				<p>CodeIgniter is a PHP web application framework that helps developers build dynamic and robust web applications quickly and easily. It follows the Model-View-Controller (MVC) architecture, which separates the application logic into three interconnected components, making it easier to manage and maintain code.</p>
			</div>
			<div class="col-md-4">
				<h2>Why Choose CodeIgniter?</h2>
				<ul>
					<li>Easy to learn and use</li>
					<li>Lightweight and fast</li>
					<li>Flexible and scalable</li>
					<li>Great community support</li>
				</ul>
			</div>
		</div>
	</div>

	<!-- Footer -->
	<footer class="py-3 footer">
		<div class="container">
			<p class="text-center">&copy; 2023 Rycahaya Sri Hutomo</p>
		</div>
	</footer>

	<!-- Bootstrap JavaScript -->
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
	<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
	<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</body>
</html>

<?php

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::get('/', "WebsiteController@Homepage")->name('homepage');
Route::get('/add', function () { return view('add'); });
Route::get('/update', "WebsiteController@Update");
Route::get('/add-task', function () { return redirect('/'); });
Route::get('/update-task', function () { return redirect('/'); });
Route::post('/add-task', "WebsiteController@Add");
Route::post('/delete-task', "WebsiteController@Delete");
Route::post('/update-task', "WebsiteController@UpdateTasks");
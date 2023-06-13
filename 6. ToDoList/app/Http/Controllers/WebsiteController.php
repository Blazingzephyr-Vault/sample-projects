<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use App\Task as Task;

class WebsiteController extends Controller
{        
    public function Homepage() 
    {   
        $table = new Task;
        $data = $table->all();

        return view('homepage', ['data' => $data]);
    }

    public function Add(Request $request) 
    {
        WebsiteController::ValidateTask($request);
        $task = new Task;
        WebsiteController::UpdateTask($request, $task);
        $task->save();

        return redirect()->route('homepage');
    }
    
    public function Delete(Request $request) 
    {
        DB::table('tasks')->where('id', $request['id'])->delete();
        return redirect()->route('homepage');
    }

    public function Update(Request $request) 
    {
        $data = Task::find($request['id']);
        return view('update', ['data' => $data]);
    }

    public function UpdateTasks(Request $request) 
    {
        WebsiteController::ValidateTask($request);
        $task = Task::find($request->input('id'));
        WebsiteController::UpdateTask($request, $task);
        $task->update();
        
        return redirect()->route('homepage');
    }

    public function ValidateTask(Request $request)
    {
        $passed = $request->validate([
            'title' => [
                'required',
                'min:3',
                'max:100'
            ],
            'description' => [
                'required',
                'min:3',
                'max:500'
            ],
            'starts' => [
                'required',
                'date'
            ],
            'ends' => [
                'required',
                'date'
            ]
        ]);
    }

    public function UpdateTask(Request $request, Task $task)
    {
        $task->title = $request->input('title');
        $task->description = $request->input('description');
        $task->starts = $request->input('starts');
        $task->ends = $request->input('ends');
        $task->status = $request->input('status');
    }
}
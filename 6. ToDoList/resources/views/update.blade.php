@extends('template')
@section('title')
Update Task
@endsection

@section('body')
    @if($errors->any())
        <div class="alert alert-danger">
            <ul>
                @foreach($errors->all() as $error)
                <li>{{ $error }}</li>
                @endforeach
            </ul>
        </div>
    @endif

    <form method="POST" action="update-task">
        <input type="hidden" name="_token" value="{{ csrf_token() }}" />
        <?php echo '<input type="hidden" value="'.$data['id'].'" name="id">'; ?>
        <ul>
            <li>Title:<br></li>
            <?php echo '<li><input type="text" name="title" value="'.$data['title'].'"><br><br></li>'; ?>
            <li>Description:<br></li>
            <?php echo '<li><input type="text" name="description" value="'.$data['description'].'"><br><br></li>'; ?>
            <li>Starts:<br></li>
            <?php echo '<li><input type="datetime-local" name="starts" value="'.$data['starts'].'"><br><br></li>'; ?>
            <li>Ends:<br></li>
            <?php echo '<li><input type="datetime-local" name="ends" value="'.$data['ends'].'"><br><br></li>'; ?>
            <li>Status:<br></li>
            <?php
                echo '<li><select name="status"><option value="Started"';
                if ($data['status'] === 'Started')
                {
                    echo ' selected';
                }
                echo '>Started</option><option value="In Progress"';
                if ($data['status'] === 'In Progress')
                {
                    echo ' selected';
                }
                echo '>In Progress</option><option value="Completed"';
                if ($data['status'] === 'Completed')
                {
                    echo ' selected';
                }
                echo '>Completed</option></select><br><br></li>';
            ?>
            <input type="submit">
        </ul>
    </form>
@endsection
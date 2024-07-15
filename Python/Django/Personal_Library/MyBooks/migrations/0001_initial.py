# Generated by Django 4.2 on 2023-07-07 03:06

from django.db import migrations, models
import django.db.models.deletion


class Migration(migrations.Migration):

    initial = True

    dependencies = [
    ]

    operations = [
        migrations.CreateModel(
            name='Authors',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('email', models.EmailField(max_length=100)),
            ],
            options={
                'db_table': 'authors',
            },
        ),
        migrations.CreateModel(
            name='Publishers',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('website', models.CharField(max_length=100)),
            ],
            options={
                'db_table': 'publishers',
            },
        ),
        migrations.CreateModel(
            name='SubTopics',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('name', models.CharField(max_length=100)),
            ],
            options={
                'db_table': 'subtopics',
            },
        ),
        migrations.CreateModel(
            name='Topics',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('name', models.CharField(max_length=100)),
            ],
            options={
                'db_table': 'topics',
            },
        ),
        migrations.CreateModel(
            name='Books',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('isbn', models.CharField(max_length=23)),
                ('author', models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, to='MyBooks.authors')),
                ('publisher', models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, to='MyBooks.publishers')),
                ('subtopic', models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, to='MyBooks.subtopics')),
                ('topic', models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, to='MyBooks.topics')),
            ],
            options={
                'db_table': 'books',
            },
        ),
    ]
